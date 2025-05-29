using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task OnGetAsync(int? professionalId = null)
        {
            if (professionalId.HasValue)
            {
                Appointments = await _context.Appointments
                    .Include(a => a.Patient)
                    .Where(a => a.ProfessionalId == professionalId.Value)
                    .ToListAsync();
            }
            else
            {
                Appointments = await _context.Appointments
                    .Include(a => a.Patient)
                    .ToListAsync();
            }
        }
    }
}
