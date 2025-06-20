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

        public IList<Appointment> Appointments { get; set; } = new List<Appointment>();
        public List<SelectListItem> ProfessionalOptions { get; set; } = new();
        public List<SelectListItem> AvailableTimes { get; set; } = new();
        public List<string> Specialities { get; set; } = new();
        public string? SelectedSpeciality { get; set; }

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

        public async Task OnGetAsync(string? speciality)
        {
            SelectedSpeciality = speciality;
            Specialities = await _context.Professionals
                .Select(p => p.Specialization)
                .Distinct()
                .OrderBy(s => s)
                .ToListAsync();

            var userEmail = User.FindFirstValue(ClaimTypes.Email) ?? User.Identity?.Name;
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.Email == userEmail);
            if (patient != null)
            {
                await LoadAppointmentsAndProfessionals(patient.Id, speciality);
            }
            else
            {
                Appointments = new List<Appointment>();
                ProfessionalOptions = new List<SelectListItem>();
            }
            LoadAvailableTimes(NewAppointment.ProfessionalId != 0 ? NewAppointment.ProfessionalId : (int?)null, NewAppointment.Date != DateTime.MinValue ? NewAppointment.Date : (DateTime?)null);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Specialities = await _context.Professionals
                .Select(p => p.Specialization)
                .Distinct()
                .OrderBy(s => s)
                .ToListAsync();

            var userEmail = User.FindFirstValue(ClaimTypes.Email) ?? User.Identity?.Name;
            var patient = await _context.Patients.FirstOrDefaultAsync(p => p.Email == userEmail);
            if (patient == null)
            {
                ModelState.AddModelError(string.Empty, "Could not resolve patient for current user.");
                await LoadAppointmentsAndProfessionals(null, null);
                LoadAvailableTimes();
                return Page();
            }

            if (!ModelState.IsValid)
            {
                await LoadAppointmentsAndProfessionals(patient.Id, null);
                LoadAvailableTimes(NewAppointment.ProfessionalId != 0 ? NewAppointment.ProfessionalId : (int?)null, NewAppointment.Date != DateTime.MinValue ? NewAppointment.Date : (DateTime?)null);
                return Page();
            }

            // Prevent double-booking for the same professional, date, and time
            bool slotTaken = await _context.Appointments.AnyAsync(a =>
                a.ProfessionalId == NewAppointment.ProfessionalId &&
                a.Date == NewAppointment.Date &&
                a.Time == NewAppointment.Time);
            if (slotTaken)
            {
                ModelState.AddModelError("NewAppointment.Time", "This time slot is already taken for the selected professional and date.");
                await LoadAppointmentsAndProfessionals(patient.Id, null);
                LoadAvailableTimes(NewAppointment.ProfessionalId != 0 ? NewAppointment.ProfessionalId : (int?)null, NewAppointment.Date != DateTime.MinValue ? NewAppointment.Date : (DateTime?)null);
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

        private async Task LoadAppointmentsAndProfessionals(int? patientId, string? speciality)
        {
            var professionalsQuery = _context.Professionals.AsQueryable();
            if (!string.IsNullOrWhiteSpace(speciality))
            {
                professionalsQuery = professionalsQuery.Where(p => p.Specialization == speciality);
            }
            ProfessionalOptions = await professionalsQuery
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

        private void LoadAvailableTimes(int? professionalId = null, DateTime? date = null)
        {
            var allTimes = new List<SelectListItem>
            {
                new SelectListItem { Value = "09:00", Text = "09:00" },
                new SelectListItem { Value = "10:00", Text = "10:00" },
                new SelectListItem { Value = "11:00", Text = "11:00" },
                new SelectListItem { Value = "13:00", Text = "13:00" },
                new SelectListItem { Value = "14:00", Text = "14:00" },
                new SelectListItem { Value = "15:00", Text = "15:00" }
            };

            if (professionalId.HasValue && date.HasValue)
            {
                var takenTimes = _context.Appointments
                    .Where(a => a.ProfessionalId == professionalId.Value && a.Date == date.Value)
                    .Select(a => a.Time)
                    .ToList();
                AvailableTimes = allTimes.Where(t => !takenTimes.Contains(t.Value)).ToList();
            }
            else
            {
                AvailableTimes = allTimes;
            }
        }
    }
}
