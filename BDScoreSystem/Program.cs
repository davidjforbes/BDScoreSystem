using BDScoreSystem.Components;
using BDScoreSystem.Data.Models;
using BDScoreSystem.Interfaces;
using BDScoreSystem.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<BDScoreDbContext>(o => o.UseSqlServer());
builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddScoped<IBDScoreService, BDScoreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
