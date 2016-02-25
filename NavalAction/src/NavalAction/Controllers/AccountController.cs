using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Authorization;
using NavalAction.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NavalAction.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;
        IdentityDbContext _identyContext;
        private readonly Task _identityContext;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IdentityDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _identyContext = dbContext;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel viewModel, string returnUrl)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            // Skapa DB-schema
            await _identityContext.Database.EnsureCreatedAsync();

            // Skapa användaren
            var result = await _userManager.CreateAsync(new IdentityUser(
                viewModel.UserName), viewModel.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(nameof(LoginViewModel.Password), result.Errors.First().Description);
                return View(viewModel);
            }

            // Logga in användaren
            await _signInManager.PasswordSignInAsync(viewModel.UserName, viewModel.Password,
                false, false);

            // Omdirigera användaren
            if (string.IsNullOrWhiteSpace(returnUrl))
                return RedirectToAction("index");
            else
                return Redirect(returnUrl);
        }

    }
}
