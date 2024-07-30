using Microsoft.AspNetCore.Components.Web;

using TaskCloud.WebApp.Components;
using TaskCloud.WebApp.Components.Pages;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(options =>
    {
        options.RootComponents.RegisterForJavaScript<Tasks>(identifier: "home",
          javaScriptInitializer: "initializeComponent");

        options.RootComponents.RegisterForJavaScript<Tasks>(identifier: "tasks",
          javaScriptInitializer: "initializeComponent");
    });

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
