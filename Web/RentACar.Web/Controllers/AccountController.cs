namespace RentACar.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using RentACar.Data.Common.Repositories;
    using RentACar.Data.Models;
    using RentACar.Web.ViewModels.Registration;

    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IDeletableEntityRepository<ApplicationUser> users;

        public AccountController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IDeletableEntityRepository<ApplicationUser> users)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.users = users;
        }

        public async Task<IActionResult> GetCurrentInfo()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            
            return this.Json(user);
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                //var user = new ApplicationUser
                //{
                //    UserName = model.U
                //};

                // if (result.Succeeded)
                //{
                //    await _signInManager.SignInAsync(user, isPersistent: false);

                //    return this.RedirectToAction("index", "Home");
                //}

                //foreach (var error in result.Errors)
                //{
                //    this.ModelState.AddModelError(" ", error.Description);
                //}

                //this.ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return this.View(model);
        }
    }
}
