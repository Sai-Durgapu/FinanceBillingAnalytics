using FinanceBilling.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace FinanceBilling.Infrastructure.Identity;

public static class IdentitySeeder
{
    public static async Task SeedAdminAsync(
        UserManager<ApplicationUser> userManager)
    {
        var email = "admin@finance.com";

        var user = await userManager.FindByEmailAsync(email);

        if (user == null)
        {
            user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FullName = "System Administrator"
            };

            await userManager.CreateAsync(
                user,
                "Admin@123"
            );

            await userManager.AddToRoleAsync(
                user,
                "Admin"
            );
        }
    }
}