using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoaCA1.Models;

namespace SoaCA1.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<RegisterModel> _logger;
       

        public RegisterModel(ILogger<RegisterModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public new UserModel User { get; set; } = new UserModel();

        public void OnGet()
        {
          
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();

            }
            return RedirectToPage("/Index", new  {User.Name });
        }


    }
}
