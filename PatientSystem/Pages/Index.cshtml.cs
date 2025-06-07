using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PatientSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(ILogger<IndexModel> logger/*, RoleManager<IdentityRole> roleManager*/)
        {
            _logger = logger;
            //_roleManager = roleManager;
        }

        public void OnGet()
        {
            _logger.LogInformation("Index page >>>");

            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Professional"))
                {
                    Response.Redirect("/Proffesionalz/Dashboard");
                }
                else if (User.IsInRole("Patient"))
                {
                    Response.Redirect("/Patientz/MyMedicalRecord");
                }
                else if (User.IsInRole("Admin"))
                {
                    Response.Redirect("/Admin/Index");
                }
            }
        }
    }
}
