using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoaCA1.Services;
namespace SoaCA1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientService _httpClientService;
        private readonly IConfiguration _configuration;
        public IndexModel(ILogger<IndexModel> logger,IHttpClientService clientService,IConfiguration conf)
            
        {
            _httpClientService = clientService;
            _configuration = conf;
            _logger = logger;
        }

        [BindProperty(SupportsGet = true)]
        public string Email { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public void OnGet()
        {
            if (Name == null)
            {
                Name = "John Doe from Get method";
            }


    

        }



    }
}