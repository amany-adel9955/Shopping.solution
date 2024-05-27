using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shopping.web.Services.Classes;
using Shopping.web.Services.Contracts;

namespace Shopping.web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7145/api/") }); // http client object to call action methods with api components
            builder.Services.AddScoped<IProductService, Productservice>();

            await builder.Build().RunAsync();

        }
    }
}
