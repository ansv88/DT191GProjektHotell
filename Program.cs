using DT191GProjektHotell.Components;
using DT191GProjektHotell.Data;
using DT191GProjektHotell.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Server;

namespace DT191GProjektHotell;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Hämta connection string från appsettings.json
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

        // Registrera DbContextFactory
        builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

        // Lägg till Razor Pages för Identity UI
        builder.Services.AddRazorPages();

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddAuthorization();

        // Lägg till Identity med UI
        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
        })
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

        builder.Services.Configure<CircuitOptions>(options =>
        {
            options.DetailedErrors = true;
        });

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/admin";
            options.AccessDeniedPath = "/";
            options.Cookie.Name = ".AspNetCore.Identity.Application";
        });

        builder.Services.AddHttpClient("AppAPI", client =>
        {
            client.BaseAddress = new Uri("https://localhost:7209/");
        });

        // Registrera HttpClient som standard
        builder.Services.AddScoped(sp =>
            sp.GetRequiredService<IHttpClientFactory>().CreateClient("AppAPI"));

        builder.Services.AddControllers();

        builder.Services.Configure<CircuitOptions>(o => o.DetailedErrors = true);

        var app = builder.Build();

        // Läs in admin-uppgifter från config/miljövariabler
        var adminEmail = app.Configuration["AdminAccount:Email"];
        var adminPassword = app.Configuration["AdminAccount:Password"];

        if (string.IsNullOrWhiteSpace(adminEmail) || string.IsNullOrWhiteSpace(adminPassword))
        {
            throw new Exception("Admin-e-post och lösenord måste anges i appsettings.json eller som miljövariabler!");
        }

        // Se till att databasen finns och migrationer är körda
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            db.Database.Migrate();

            // Kör runtime-seeding av Admin-användare
            await StartupSeeder.SeedAdminUserAsync(app.Services, adminEmail, adminPassword);
        }

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.MapStaticAssets();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.UseAntiforgery();

        app.MapControllers();

        // Razor Pages för Identity UI
        app.MapRazorPages();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        await app.RunAsync();
    }
}