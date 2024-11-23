using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio.BlazorWasm;
using MyPortfolio.BlazorWasm.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//injecao de dependencias
builder.Services.injectDependences();

builder.Services.
    AddHttpClient(WebConfiguration.Name,
    opt =>
    {
#if DEBUG
        opt.BaseAddress = new Uri("http://localhost:5260/V1/api");
#endif

        opt.BaseAddress = new Uri("https://paulodev.azurewebsites.net/V1/api");
    });


await builder.Build().RunAsync();