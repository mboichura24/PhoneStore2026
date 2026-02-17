using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using static System.Formats.Asn1.AsnWriter;

namespace UI.Helpers
{
    public static class SeedHelper
    {
        public static async Task SeedIdentities(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var provider = scope.ServiceProvider;

                var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();
                IdentityRole role = new IdentityRole("Admin");
                await roleManager.CreateAsync(role);

                var userManager = provider.GetRequiredService<UserManager<IdentityUser>>();
                IdentityUser user = await userManager.FindByEmailAsync("m.v.boichura@nuwm.edu.ua");
                await userManager.AddToRoleAsync(user, role.Name);
            }
        }
    }
}
