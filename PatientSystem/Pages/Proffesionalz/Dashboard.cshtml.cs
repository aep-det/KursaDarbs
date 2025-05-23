using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
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

        public List<SelectListItem> PatientOptions { get; set; } = new();
        public string? SelectedPatientId { get; set; }

        public async Task OnGetAsync(int? patientId = null)
        {
            await LoadPatients();
            SelectedPatientId = patientId?.ToString();
        }

        private async Task LoadPatients()
        {
            PatientOptions = await _context.Patients
                .Select(p => new SelectListItem { Value = p.Id.ToString(), Text = p.Name })
                .ToListAsync();
        }
    }
}
