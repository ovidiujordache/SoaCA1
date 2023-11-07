using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoaCA1.Services;

namespace SoaCA1.Pages
{
    public class ClientModel : PageModel
    {
        private readonly IHttpClientService _httpClientService;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ClientModel> _logger;

        public ClientModel(ILogger<ClientModel> logger, IHttpClientService clientService, IConfiguration conf)

        {
            _logger = logger;
            _httpClientService = clientService;
            _configuration = conf;
        }


        [BindProperty(SupportsGet = true)]
        public string GetClientToken { get; set; }
        public void OnGet()
        {
          AuthUser();

        }
        public async  Task<IActionResult> AuthUser()
        {

            try
            {
              var token = await _httpClientService.GetClientToken(_configuration["Spotify:client_id"],
                                        _configuration["Spotify:client_secret"]);
                System.Diagnostics.Debug.WriteLine("no tokennnn");
                _logger.LogInformation("Token is " + token);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return Page(); ;
        }

    }
}
