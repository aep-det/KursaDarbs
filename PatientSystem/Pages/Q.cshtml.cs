using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PatientSystem.Pages
{
    public class QModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;

        public QModel(Data.ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

            var q = _context.Appointments
                .Select(s => new { s.Status, s.Time }); // @* .Include(a => a.Professional) *@


        } 
    }
}
