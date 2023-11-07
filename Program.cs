using SoaCA1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
/*adding http client service with URL */
builder.Services.AddHttpClient<IHttpClientService, HttpClientService>(urlApi =>
{
    urlApi.BaseAddress = new Uri("https://accounts.spotify.com/api/");
});
//adding configuration file for credentials and other settings  
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
