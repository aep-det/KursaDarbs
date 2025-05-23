using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatientSystem.Data;

namespace PatientSystem.Pages.Proffesionalz
{
    public class CreateModel : PageModel
    {
        private readonly PatientSystem.Data.ApplicationDbContext _context;

        public CreateModel(PatientSystem.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Professional Professional { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Professionals.Add(Professional);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
