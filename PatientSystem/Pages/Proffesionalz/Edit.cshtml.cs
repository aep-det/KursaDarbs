using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PatientSystem.Data;

namespace PatientSystem.Pages.Proffesionalz
{
    public class EditModel : PageModel
    {
        private readonly PatientSystem.Data.ApplicationDbContext _context;

        public EditModel(PatientSystem.Data.ApplicationDbContext context)
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

            var professional =  await _context.Professionals.FirstOrDefaultAsync(m => m.Id == id);
            if (professional == null)
            {
                return NotFound();
            }
            Professional = professional;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Professional).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessionalExists(Professional.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProfessionalExists(int id)
        {
            return _context.Professionals.Any(e => e.Id == id);
        }
    }
}
