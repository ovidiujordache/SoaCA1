
namespace SoaCA1.Services
{
    public interface IHttpClientService
    {
        public Task<String>
            GetClientToken
            (string client_id, string client_secret);
    }
}
