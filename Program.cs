using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Portfolio_Page.Controllers;
using Portfolio_Page.Services;
using System.Net.Http;

namespace Portfolio_Page
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Register root components
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            // Register HttpClient as scoped (this is default in Blazor WASM)
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

            // Registering services as SCOPED (not singleton!)
            builder.Services.AddScoped<ProjectServices>();
            builder.Services.AddScoped<BlogServices>();
            builder.Services.AddScoped<ProjectController>(); // optional

            await builder.Build().RunAsync();
        }
    }
}
