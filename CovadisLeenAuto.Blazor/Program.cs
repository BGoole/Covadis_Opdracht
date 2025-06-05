using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CovadisLeenAuto.Blazor;

namespace CovadisLeenAuto.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            var apiUrl = "https://localhost:7068/";
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiUrl) });

            await builder.Build().RunAsync();
        }
    }
}
