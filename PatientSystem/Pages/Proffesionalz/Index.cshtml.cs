using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;

namespace PatientSystem.Pages.Proffesionalz
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PatientSystem.Data.ApplicationDbContext _context;

        public IndexModel(PatientSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Professional> Professional { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Professional = await _context.Professionals.ToListAsync();
        }
    }
}


