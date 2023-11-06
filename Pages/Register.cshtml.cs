using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SoaCA1.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<RegisterModel> _logger;

        public RegisterModel(ILogger<RegisterModel> logger)
        {
            _logger = logger;
        }

        public void OnGet() => Console.WriteLine("RegisterModel.OnGet() called");

    }
}
