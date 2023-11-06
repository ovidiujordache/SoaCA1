using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SoaCA1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
         

       /*     var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
            if (connectionString == null)
            {
                Console.WriteLine("You must set your 'MONGODB_URI' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/quick-start/#set-your-connection-string");
                Environment.Exit(0);
            }

            var client = new MongoClient(connectionString);

            var collection = client.GetDatabase("sample_mflix").GetCollection<BsonDocument>("movies");

            var filter = Builders<BsonDocument>.Filter.Eq("title", "Back to the Future");

            var document = collection.Find(filter).First();

            Console.WriteLine(document);*/

        }
    }
}