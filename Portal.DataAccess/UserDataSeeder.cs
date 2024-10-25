using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Portal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DataAccess
{
    public class UserDataSeeder
    {
        public static async Task Seed(IServiceProvider service)
        {
            // UserManager (Repositorio de Usuarios)
            var userManager = service.GetRequiredService<UserManager<PortalIdentityUser>>();
            // RoleManager (Repositorio de Roles)
            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            // create roles
            var adminRole = new IdentityRole(Cons.AdministratorRole);
            var studentRole = new IdentityRole(Cons.StudentRole);

            await roleManager.CreateAsync(adminRole);
            await roleManager.CreateAsync(studentRole);

            // admin user
            var adminUser = new PortalIdentityUser()
            {
                FullName = "System administrator",
                UserName = "admin",
                Email = "admin@gmail.com",
                PhoneNumber = "+1 999 999 999",
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(adminUser, "Pass1234@");
            if (result.Succeeded)
            {
                // this is for check the user was createde succesfully
                adminUser = await userManager.FindByEmailAsync(adminUser.Email);
                if (adminUser is not null)
                    await userManager.AddToRoleAsync(adminUser, Cons.AdministratorRole);
            }
        }
    }
}
