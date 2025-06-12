using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PatientSystem.Pages.Proffesionalz
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

        public async Task OnGetAsync()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email) ?? User.Identity?.Name;
            var professional = await _context.Professionals.FirstOrDefaultAsync(p => p.Email == userEmail);
            if (professional != null)
            {
                Appointments = await _context.Appointments
                    .Include(a => a.Patient)
                    .Where(a => a.ProfessionalId == professional.Id)
                    .ToListAsync();
            }
            else
            {
                Appointments = new List<Appointment>();
            }
        }
    }
}
