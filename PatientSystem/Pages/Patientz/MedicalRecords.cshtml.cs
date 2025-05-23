using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Pages.Patientz
{
    [Authorize]
    public class MedicalRecordsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public MedicalRecordsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<MedicalRecord> Records { get; set; } = new List<MedicalRecord>();
        public List<SelectListItem> PatientOptions { get; set; } = new();
        public string? SelectedPatientId { get; set; }
        public Patient? SelectedPatient { get; set; }

        [BindProperty]
        public MedicalRecordInputModel NewMedicalRecord { get; set; } = new MedicalRecordInputModel();

        public class MedicalRecordInputModel
        {
            [Required]
            public string Diagnosis { get; set; } = string.Empty;
            [Required]
            public string Treatment { get; set; } = string.Empty;
            [Required]
            public string Prescription { get; set; } = string.Empty;
            [Required]
            [DataType(DataType.Date)]
            public DateTime DateCreated { get; set; } = DateTime.Today;
        }

        public async Task OnGetAsync(int? patientId = null)
        {
            await LoadPatients();
            SelectedPatientId = patientId?.ToString();
            if (patientId.HasValue)
            {
                await LoadRecords(patientId.Value);
                SelectedPatient = await _context.Patients
                    .Where(p => p.Id == patientId.Value)
                    .Select(p => new Patient {
                        Id = p.Id,
                        Name = p.Name,
                        Email = p.Email,
                        DateOfBirth = p.DateOfBirth
                    })
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<IActionResult> OnPostAsync(int? patientId = null)
        {
            await LoadPatients();
            SelectedPatientId = patientId?.ToString();
            if (!ModelState.IsValid || !patientId.HasValue)
            {
                if (patientId.HasValue)
                {
                    await LoadRecords(patientId.Value);
                    SelectedPatient = await _context.Patients
                        .Where(p => p.Id == patientId.Value)
                        .Select(p => new Patient {
                            Id = p.Id,
                            Name = p.Name,
                            Email = p.Email,
                            DateOfBirth = p.DateOfBirth
                        })
                        .FirstOrDefaultAsync();
                }
                return Page();
            }

            var record = new MedicalRecord
            {
                Diagnosis = NewMedicalRecord.Diagnosis,
                Treatment = NewMedicalRecord.Treatment,
                Prescription = NewMedicalRecord.Prescription,
                DateCreated = NewMedicalRecord.DateCreated,
                PatientId = patientId.Value
            };
            _context.MedicalRecords.Add(record);
            await _context.SaveChangesAsync();

            NewMedicalRecord = new MedicalRecordInputModel();
            return RedirectToPage(new { patientId });
        }

        private async Task LoadRecords(int patientId)
        {
            Records = await _context.MedicalRecords
                .Where(r => r.PatientId == patientId)
                .ToListAsync();
        }

        private async Task LoadPatients()
        {
            PatientOptions = await _context.Patients
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name })
                .ToListAsync();
        }
    }
}
