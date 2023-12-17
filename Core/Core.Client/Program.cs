using Core.Client;
using Core.Framework.Client;
using Core.Framework.Common.Lib.I18N;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

BuilderdProgram.Builder<AppConfig>(builder, new AppConfig());

await builder.Build().RunAsync();
