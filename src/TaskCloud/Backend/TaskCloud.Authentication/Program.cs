using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;

using TaskCloud.Authentication.Data;
using TaskCloud.Authentication.Models;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.AddNpgsqlDbContext<ApplicationDbContext>("identitydb");

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddIdentityServer(options =>
{
    options.Authentication.CookieLifetime = TimeSpan.FromHours(2);

    options.Events.RaiseErrorEvents = true;
    options.Events.RaiseInformationEvents = true;
    options.Events.RaiseFailureEvents = true;
    options.Events.RaiseSuccessEvents = true;

    options.KeyManagement.Enabled = false;
}).AddAspNetIdentity<ApplicationUser>()
// Not recommended for production - you need to store your key material somewhere secure
.AddDeveloperSigningCredential();

var app = builder.Build();

app.MapDefaultEndpoints();

app.UseStaticFiles();

app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
