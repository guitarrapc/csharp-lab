using BlazorServerIPBlockApp.Data;
using BlazorServerIPBlockApp.Middlewares;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Want to access HttpContext
builder.Services.AddHttpContextAccessor();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

// Register SafeIP Middleware
app.UseMiddleware<DebugSafeIPListMiddleware>(app.Configuration.GetSection("DebugSafeIP").Get<DebugSafeIPOption>());

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
