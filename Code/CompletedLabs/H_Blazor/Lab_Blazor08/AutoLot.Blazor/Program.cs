// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - Program.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

using AutoLot.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICarDataService, CarDataService>();
builder.Services.AddScoped<IMakeDataService, MakeDataService>();
builder.Services.Configure<DealerInfo>(builder.Configuration.GetSection(nameof(DealerInfo)));

builder.Services.AddTransient<OutputLog>();
builder.Services.AddModelValidation();
builder.Services.AddValidation();
builder.Services.AddKeyedScoped(typeof(IBrowserStorageService<>), nameof(LocalStorageService<>), typeof(LocalStorageService<>));
builder.Services.AddKeyedScoped(typeof(IBrowserStorageService<>), nameof(SessionStorageService<>), typeof(SessionStorageService<>));
await builder.Build().RunAsync();
