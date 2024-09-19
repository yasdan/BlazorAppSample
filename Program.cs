using BlazorAppSample;
using BlazorAppSample.DataModel;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddHttpClient<AdminService>();
builder.Services.AddScoped<AdminService>();
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["https://jsonplaceholder.typicode.com/users"])});
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com/users")});

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

