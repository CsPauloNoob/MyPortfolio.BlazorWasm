using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio.BlazorWasm;
using MyPortfolio.BlazorWasm.Extensions;
using MudBlazor.Services;
using MyPortfolio.BlazorWasm.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


//injecao de dependencias
builder.Services.injectDependences();
builder.Services.AddSingleton<DrawerState>();

builder.Services.AddMudServices();

builder.Services.
    AddHttpClient(WebConfiguration.Name,
    opt =>
    {
        opt.BaseAddress = new Uri("https");
    });


await builder.Build().RunAsync();