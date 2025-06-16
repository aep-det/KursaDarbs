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
    public class DirectoryModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DirectoryModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Professional> Professionals { get; set; } = new List<Professional>();
        public List<string> Specializations { get; set; } = new();
        public string? SearchTerm { get; set; }
        public string? SelectedSpecialization { get; set; }

        public async Task OnGetAsync(string? search, string? specialization)
        {
            SearchTerm = search;
            SelectedSpecialization = specialization;
            Specializations = await _context.Professionals
                .Select(p => p.Specialization)
                .Distinct()
                .OrderBy(s => s)
                .ToListAsync();

            var query = _context.Professionals.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p => p.Name.Contains(search));
            }
            if (!string.IsNullOrWhiteSpace(specialization))
            {
                query = query.Where(p => p.Specialization == specialization);
            }
            Professionals = await query.ToListAsync();
        }
    }
}
