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
        public List<Note> NotesList { get; set; } = new();
        [BindProperty]
        public string NewNoteText { get; set; } = string.Empty;

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
            NotesList = await _context.Notes.Where(n => n.PatientId == id).OrderByDescending(n => n.CreatedAt).ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostEditMedicationAsync(int id)
        {
            int medId = int.Parse(Request.Form["MedicationId"]);
            var med = await _context.Medications.FirstOrDefaultAsync(m => m.Id == medId);
            if (med == null)
                return NotFound();

            med.Dosage = Request.Form["Dosage"];
            med.StartDate = DateTime.Parse(Request.Form["StartDate"]);
            var endDateStr = Request.Form["EndDate"];
            med.EndDate = string.IsNullOrWhiteSpace(endDateStr) ? null : DateTime.Parse(endDateStr);
            await _context.SaveChangesAsync();
            return RedirectToPage(new { id });
        }

        public async Task<IActionResult> OnPostDeleteMedicationAsync(int id, int medicationId)
        {
            var med = await _context.Medications.FirstOrDefaultAsync(m => m.Id == medicationId);
            if (med != null)
            {
                _context.Medications.Remove(med);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage(new { id });
        }

        public async Task<IActionResult> OnPostAddMedicationAsync(int id)
        {
            var name = Request.Form["Name"];
            var dosage = Request.Form["Dosage"];
            var startDate = DateTime.Parse(Request.Form["StartDate"]);
            var endDateStr = Request.Form["EndDate"];
            DateTime? endDate = string.IsNullOrWhiteSpace(endDateStr) ? null : DateTime.Parse(endDateStr);

            var medication = new Medication
            {
                PatientId = id,
                Name = name,
                Dosage = dosage,
                StartDate = startDate,
                EndDate = endDate
            };
            _context.Medications.Add(medication);
            await _context.SaveChangesAsync();
            return RedirectToPage(new { id });
        }

        public async Task<IActionResult> OnPostAddNoteAsync(int id)
        {
            if (!string.IsNullOrWhiteSpace(NewNoteText))
            {
                var note = new Note
                {
                    PatientId = id,
                    Text = NewNoteText,
                    CreatedAt = DateTime.Now
                };
                _context.Notes.Add(note);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage(new { id });
        }
    }
}
