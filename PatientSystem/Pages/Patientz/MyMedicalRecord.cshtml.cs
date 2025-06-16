using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System;

namespace PatientSystem.Pages.Patientz
{
    [Authorize(Roles = "Patient")]
    public class MyMedicalRecordModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public MyMedicalRecordModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public Patient? Patient { get; set; }
        public IList<MedicalRecord> Records { get; set; } = new List<MedicalRecord>();
        public List<Appointment> UpcomingAppointments { get; set; } = new();
        public List<string> Allergies { get; set; } = new(); // Placeholder
        public List<Medication> Medications { get; set; } = new();
        public string Notes { get; set; } = string.Empty; // Placeholder
        public List<Note> NotesList { get; set; } = new();

        public async Task<IActionResult> OnGetAsync()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            if (string.IsNullOrEmpty(userEmail))
                return Challenge();

            Patient = await _context.Patients.FirstOrDefaultAsync(p => p.Email == userEmail);
            if (Patient == null)
                return NotFound();

            Records = await _context.MedicalRecords
                .Where(r => r.PatientId == Patient.Id)
                .OrderByDescending(r => r.DateCreated)
                .ToListAsync();

            UpcomingAppointments = await _context.Appointments
                .Include(a => a.Professional)
                .Where(a => a.PatientId == Patient.Id && a.Date >= DateTime.Today)
                .OrderBy(a => a.Date)
                .ToListAsync();

            Allergies = new List<string> { "Penicillin", "Peanuts" };
            Medications = await _context.Medications.Where(m => m.PatientId == Patient.Id).ToListAsync();
            NotesList = await _context.Notes.Where(n => n.PatientId == Patient.Id).OrderByDescending(n => n.CreatedAt).ToListAsync();
            return Page();
        }
    }
}
