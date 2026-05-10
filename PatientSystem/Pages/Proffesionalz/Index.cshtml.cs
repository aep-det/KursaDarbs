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
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly PatientSystem.Data.ApplicationDbContext _context;

        public IndexModel(PatientSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Professional> Professional { get;set; } = default!;
        
        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;
        
        public int PageSize { get; set; } = 10;
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }

        public async Task OnGetAsync()
        {
            TotalRecords = await _context.Professionals.CountAsync();
            TotalPages = (int)Math.Ceiling(TotalRecords / (double)PageSize);
            
            if (PageNumber < 1) PageNumber = 1;
            if (PageNumber > TotalPages && TotalPages > 0) PageNumber = TotalPages;
            
            Professional = await _context.Professionals
                .Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}


