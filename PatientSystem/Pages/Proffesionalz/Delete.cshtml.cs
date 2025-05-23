using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;

namespace PatientSystem.Pages.Proffesionalz
{
    public class DeleteModel : PageModel
    {
        private readonly PatientSystem.Data.ApplicationDbContext _context;

        public DeleteModel(PatientSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Professional Professional { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professional = await _context.Professionals.FirstOrDefaultAsync(m => m.Id == id);

            if (professional == null)
            {
                return NotFound();
            }
            else
            {
                Professional = professional;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professional = await _context.Professionals.FindAsync(id);
            if (professional != null)
            {
                Professional = professional;
                _context.Professionals.Remove(Professional);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
