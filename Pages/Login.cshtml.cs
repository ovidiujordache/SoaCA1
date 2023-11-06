using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SoaCA1.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() => Console.WriteLine("LoginModel.OnGet() called");

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();

            }
            return RedirectToPage("/Index");
        }

    }

}
