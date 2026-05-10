using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientSystem.Pages.Patientz
{
    [Authorize(Roles = "Admin")]
    public class IndexModel : PageModel
    {
        private readonly PatientSystem.Data.ApplicationDbContext _context;

        public IndexModel(PatientSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Patient> Patient { get; set; } = default!;
        
        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;
        
        public int PageSize { get; set; } = 10;
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }

        public async Task OnGetAsync()
        {
            TotalRecords = await _context.Patients.CountAsync();
            TotalPages = (int)Math.Ceiling(TotalRecords / (double)PageSize);
            
            if (PageNumber < 1) PageNumber = 1;
            if (PageNumber > TotalPages && TotalPages > 0) PageNumber = TotalPages;
            
            Patient = await _context.Patients
                .Skip((PageNumber - 1) * PageSize)
                .Take(PageSize)
                .ToListAsync();
        }
    }
}
