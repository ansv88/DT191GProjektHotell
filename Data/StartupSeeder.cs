using DT191GProjektHotell.Models;
using Microsoft.AspNetCore.Identity;

namespace DT191GProjektHotell.Data;

public static class StartupSeeder
{
    public static async Task SeedAdminUserAsync(IServiceProvider serviceProvider, string adminEmail, string adminPassword)
    {
        using var scope = serviceProvider.CreateScope();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        // Skapa Admin-roll om den inte finns
        var adminRoleName = "Admin";
        var adminRole = await roleManager.FindByNameAsync(adminRoleName);
        if (adminRole == null)
        {
            await roleManager.CreateAsync(new IdentityRole(adminRoleName));
        }

        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true
            };
            var createResult = await userManager.CreateAsync(adminUser, adminPassword);
            if (!createResult.Succeeded)
            {
                var errorMsg = string.Join(", ", createResult.Errors.Select(e => e.Description));
                throw new Exception($"Kunde inte skapa admin-användare: {errorMsg}");
            }
        }

        var rolesForUser = await userManager.GetRolesAsync(adminUser);
        if (!rolesForUser.Contains(adminRoleName))
        {
            await userManager.AddToRoleAsync(adminUser, adminRoleName);
        }
    }
}