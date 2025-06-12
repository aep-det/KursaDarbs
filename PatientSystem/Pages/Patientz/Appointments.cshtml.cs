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
using System.Security.Claims;

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
        public AppointmentInputModel NewAppointment { get; set; } = new AppointmentInputModel
        {
            Date = DateTime.Today
        };

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

        public async Task OnGetAsync()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email) ?? User.Identity?.Name;
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.Email == userEmail);
            if (patient != null)
            {
                await LoadAppointmentsAndProfessionals(patient.Id);
            }
            else
            {
                Appointments = new List<Appointment>();
            }
            LoadAvailableTimes();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            LoadAvailableTimes();
            var userEmail = User.FindFirstValue(ClaimTypes.Email) ?? User.Identity?.Name;
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.Email == userEmail);
            if (patient == null)
            {
                ModelState.AddModelError(string.Empty, "Could not resolve patient for current user.");
                await LoadAppointmentsAndProfessionals(null);
                return Page();
            }

            if (!ModelState.IsValid)
            {
                await LoadAppointmentsAndProfessionals(patient.Id);
                return Page();
            }

            var appointment = new Appointment
            {
                Date = NewAppointment.Date,
                Time = NewAppointment.Time,
                ProfessionalId = NewAppointment.ProfessionalId,
                Status = NewAppointment.Status,
                PatientId = patient.Id
            };
            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            // Clear form
            NewAppointment = new AppointmentInputModel();
            return RedirectToPage();
        }

        private async Task LoadAppointmentsAndProfessionals(int? patientId)
        {
            ProfessionalOptions = await _context.Professionals
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name })
                .ToListAsync();

            if (patientId.HasValue)
            {
                Appointments = await _context.Appointments
                    .Include(a => a.Professional)
                    .Where(a => a.PatientId == patientId.Value)
                    .ToListAsync();
            }
            else
            {
                Appointments = new List<Appointment>();
            }
        }

        private void LoadAvailableTimes()
        {
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
