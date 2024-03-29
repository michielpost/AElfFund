using AElfBlazor;
using AelfFund.Web;
using AelfFund.Web.Models;
using AelfFund.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

builder.Services.AddScoped<ChainService>();

builder.Services.AddAElfBlazor();

builder.Services.AddSingleton<UserViewModel>();

await builder.Build().RunAsync();
