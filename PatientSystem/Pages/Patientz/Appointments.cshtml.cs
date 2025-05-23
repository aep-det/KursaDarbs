using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Pages.Patientz
{
    [Authorize]
    public class AppointmentsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public AppointmentsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Use the Appointment entity from PatientSystem.Data
        public IList<Appointment> Appointments { get; set; } = new List<Appointment>();
        public List<SelectListItem> ProfessionalOptions { get; set; } = new();
        public List<SelectListItem> AvailableTimes { get; set; } = new();

        [BindProperty]
        public AppointmentInputModel NewAppointment { get; set; } = new AppointmentInputModel();

        public class AppointmentInputModel
        {
            [Required]
            [DataType(DataType.Date)]
            public DateTime Date { get; set; }

            [Required]
            public string Time { get; set; } = string.Empty;

            [Required]
            public int ProfessionalId { get; set; }

            [Required]
            public string Status { get; set; } = "Scheduled";
        }

        public async Task OnGetAsync(int? patientId = null)
        {
            await LoadAppointmentsAndProfessionals(patientId);
            LoadAvailableTimes();
        }

        public async Task<IActionResult> OnPostAsync(int? patientId = null)
        {
            LoadAvailableTimes();
            if (!ModelState.IsValid)
            {
                await LoadAppointmentsAndProfessionals(patientId);
                return Page();
            }

            // For demo: use first patient if patientId is not provided
            int resolvedPatientId = patientId ?? _context.Patients.Select(p => p.Id).FirstOrDefault();
            var appointment = new Appointment
            {
                Date = NewAppointment.Date,
                Time = NewAppointment.Time,
                ProfessionalId = NewAppointment.ProfessionalId,
                Status = NewAppointment.Status,
                PatientId = resolvedPatientId
            };
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            // Clear form
            NewAppointment = new AppointmentInputModel();
            return RedirectToPage();
        }

        private async Task LoadAppointmentsAndProfessionals(int? patientId)
        {
            if (patientId.HasValue)
            {
                Appointments = await _context.Appointments
                    .Include(a => a.Professional)
                    .Where(a => a.PatientId == patientId.Value)
                    .ToListAsync();
            }
            else
            {
                Appointments = await _context.Appointments
                    .Include(a => a.Professional)
                    .ToListAsync();
            }
            ProfessionalOptions = await _context.Professionals
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name })
                .ToListAsync();
        }

        private void LoadAvailableTimes()
        {
            // Hardcoded for now; later, fetch from Professionalz table
            AvailableTimes = new List<SelectListItem>
            {
                new SelectListItem { Value = "09:00", Text = "09:00" },
                new SelectListItem { Value = "10:00", Text = "10:00" },
                new SelectListItem { Value = "11:00", Text = "11:00" },
                new SelectListItem { Value = "13:00", Text = "13:00" },
                new SelectListItem { Value = "14:00", Text = "14:00" },
                new SelectListItem { Value = "15:00", Text = "15:00" }
            };
        }
    }
}
