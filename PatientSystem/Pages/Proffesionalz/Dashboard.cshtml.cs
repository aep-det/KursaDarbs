using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Pages.Proffesionalz
{
    [Authorize]
    public class DashboardModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DashboardModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public string? SearchTerm { get; set; }
        public List<Patient> SearchResults { get; set; } = new();
        public List<Appointment> ClosestAppointments { get; set; } = new();
        public List<NoteViewModel> Notes { get; set; } = new();
        [BindProperty]
        public string? NoteText { get; set; }

        public class NoteViewModel
        {
            public string Text { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
        }

        public async Task OnGetAsync(string? search = null)
        {
            int professionalId = 1; // Replace with actual user/professional id in real app
            SearchTerm = search;
            await LoadSearchResults(search);
            await LoadClosestAppointments(professionalId);
            await LoadNotes();
        }

        public async Task<IActionResult> OnPostAsync(string? search = null)
        {
            int professionalId = 1;
            SearchTerm = search;
            await LoadSearchResults(search);
            if (!string.IsNullOrWhiteSpace(NoteText))
            {
                Notes.Add(new NoteViewModel { Text = NoteText!, CreatedAt = DateTime.Now });
                NoteText = string.Empty;
            }
            await LoadClosestAppointments(professionalId);
            await LoadNotes();
            return Page();
        }

        private async Task LoadSearchResults(string? search)
        {
            var query = _context.Patients.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p => p.Name.Contains(search));
            }
            SearchResults = await query.ToListAsync();
        }

        private async Task LoadClosestAppointments(int professionalId)
        {
            var today = DateTime.Today;
            ClosestAppointments = await _context.Appointments
                .Include(a => a.Patient)
                .Where(a => a.ProfessionalId == professionalId && a.Date >= today)
                .OrderBy(a => a.Date).ThenBy(a => a.Time)
                .Take(10)
                .ToListAsync();
        }

        private async Task LoadNotes()
        {
            Notes = new List<NoteViewModel>();
            await Task.CompletedTask;
        }
    }
}
