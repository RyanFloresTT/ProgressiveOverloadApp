using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProgressiveOverloadApp.Shared.Services;
using ProgressiveOverloadApp.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the ProgressiveOverloadApp.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();