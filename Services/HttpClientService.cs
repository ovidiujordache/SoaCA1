using SoaCA1.Services;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using SoaCA1.Services;
using SoaCA1.Models;
namespace SoaCA1.Services

{
    //implementing the interface IHhtpClientService
    public class HttpClientService:IHttpClientService
    {
        private readonly HttpClient _client;
        public HttpClientService(HttpClient httpClient) {
            _client=httpClient;
        }

     
      public   async Task<string>  GetClientToken(string client_id, string client_secret)
        {
            var request = new HttpRequestMessage(HttpMethod.Post,"token");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{client_id}:{client_secret}")));
            
            request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials"
            });
            //throw new NotImplementedException();
            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            using  var responseStream = await response.Content.ReadAsStreamAsync();


            var authToken = await JsonSerializer.DeserializeAsync<ClientModel>(responseStream);

    
            }
    }
}
