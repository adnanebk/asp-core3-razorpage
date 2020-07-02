using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Models
{
     public static class UserAndRoleDataInitializer
    {
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }
 
        private static void SeedUsers (UserManager<ApplicationUser> userManager)
        {

            ApplicationUser user = new ApplicationUser {UserName = "admin@email", 
                Email = "admin@email",City = "berkane"};


            IdentityResult result = userManager.CreateAsync(user, "admin00").Result;
 
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }



        }
 
        private static void SeedRoles (RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
 
 
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
    }
}