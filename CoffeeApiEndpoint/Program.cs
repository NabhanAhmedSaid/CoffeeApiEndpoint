using System;
using Microsoft.AspNetCore.Builder;
string[] drinks = { "Mocha","Black Coffee","Tukish Coffe" };
WebApplicationBuilder wepAppBuilder = WebApplication.CreateBuilder(args);

WebApplication  webApp = wepAppBuilder.Build();


webApp.MapGet("api/info", (Func<string>)(() =>
    "This is C# endpoint "));

webApp.MapGet("api/drinks", (Func<string[]>)(()=>drinks));
webApp.MapGet("api/drinks/1", (Func<string>)(() => drinks[0]));
webApp.MapPost("api/year", (Func<int>)(() => 2023));

webApp.Run();