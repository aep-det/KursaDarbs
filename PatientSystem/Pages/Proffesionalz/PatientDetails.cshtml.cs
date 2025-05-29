using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace PatientSystem.Pages.Proffesionalz
{
    public class PatientDetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public PatientDetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Patient? Patient { get; set; }
        public List<Appointment> UpcomingAppointments { get; set; } = new();
        public List<string> Allergies { get; set; } = new(); // Placeholder, adjust as needed
        public List<Medication> Medications { get; set; } = new();
        public string Notes { get; set; } = string.Empty; // Placeholder, adjust as needed

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Patient = await _context.Patients.FirstOrDefaultAsync(p => p.Id == id);
            if (Patient == null)
            {
                return NotFound();
            }

            UpcomingAppointments = await _context.Appointments
                .Include(a => a.Professional)
                .Where(a => a.PatientId == id && a.Date >= DateTime.Today)
                .OrderBy(a => a.Date)
                .ToListAsync();

            // TODO: Replace with real allergies and notes logic
            Allergies = new List<string> { "Penicillin", "Peanuts" };
            Medications = await _context.Medications.Where(m => m.PatientId == id).ToListAsync();
            Notes = "Sample notes for patient.";

            return Page();
        }
    }
}
