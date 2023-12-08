using Core.Client;
using Core.Framework.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

BuilderdProgram.Builder<AppConfig>(builder, new AppConfig());

await builder.Build().RunAsync();
