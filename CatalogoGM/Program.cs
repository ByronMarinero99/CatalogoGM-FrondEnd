using CatalogoGM;
using CatalogoGM.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7062/api/") });
builder.Services.AddScoped<ICaracteristicasGameService, CaracteristicasGamesService>();

await builder.Build().RunAsync();
