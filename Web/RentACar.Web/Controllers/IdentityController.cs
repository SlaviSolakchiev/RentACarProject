using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentACar.Data.Models;
using System.Threading.Tasks;

namespace RentACar.Web.Controllers
{
    public class IdentityController : BaseController
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public IdentityController(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public async Task<IActionResult> AddUserToRole()
        {
            if (await this.roleManager.RoleExistsAsync("User"))
            {
                await this.roleManager.CreateAsync(new IdentityRole
                {
                    Name = "User",
                });
            }

            var user = await this.userManager.GetUserAsync(this.User);

            var result = await this.userManager.AddToRoleAsync(user, "User");

            return this.View();
        }
    }
}
