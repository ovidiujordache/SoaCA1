using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SoaCA1;
using SoaCA1.Services;
using System.Diagnostics;

namespace SoaCA1.Pages
{
    public class ClientModel : PageModel
    {
        private readonly IHttpClientService _httpClientService;
        private readonly IConfiguration _configuration;
        public ClientModel(IHttpClientService clientService, IConfiguration conf)

        {
            _httpClientService = clientService;
            _configuration = conf;
        }


        [BindProperty(SupportsGet = true)]
        public string GetClientToken { get; set; }
        public void OnGet()
        {
            Task<string> tokenReturned=AuthUser();
          System.Diagnostics.Debug.WriteLine(tokenReturned);
                     
        }
        public async Task<string> AuthUser()
        {
           
            try
            {
               string  token = await _httpClientService.GetClientToken(_configuration["Spotify:ClientId"],
                                       _configuration["Spotify:ClientSecret"]);
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
            return null;
        }
   
    }
}
