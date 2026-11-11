using Microsoft.EntityFrameworkCore;
using SzervizApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

// DbContext regisztrálása, a connection string az appsettings.json-ból jön
var connectionString = builder.Configuration.GetConnectionString("SzervizDb")!;
builder.Services.AddDbContext<SzervizContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

// A kezdőoldal az űrlapra visz
app.MapGet("/", () => Results.Redirect("/Bejelentes"));

app.Run();
