using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatientSystem.Pages.Proffesionalz
{
    [Authorize]
    public class DirectoryModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DirectoryModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Professional> Professionals { get; set; } = new List<Professional>();

        public async Task OnGetAsync()
        {
            Professionals = await _context.Professionals.ToListAsync();
        }
    }
}
