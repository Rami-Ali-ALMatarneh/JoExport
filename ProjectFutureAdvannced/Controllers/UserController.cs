using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
    {
    public class UserController : Controller
        {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController( UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            _userManager = userManager;
            _signInManager = signInManager;
            this._roleManager = _roleManager;
            }
        public IActionResult Index()
            {
            return View();
            }
        [HttpPost]
        public async Task<IActionResult> Create( RegisterViewModel registerViewModel )
            {
            if (ModelState.IsValid)
                {
                int indexOfAt = registerViewModel.Email.IndexOf("@");
                IdentityUser user = new IdentityUser
                    {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email.Substring(0, indexOfAt - 1),
                    };
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                    {
                    // Add the roles you want to assign to the user

                    // Check if the role exists before adding

                    if (await _roleManager.RoleExistsAsync("User"))
                        {
                        await _userManager.AddToRoleAsync(user, "User");
                    }


                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                    }
                else
                    {
                    foreach (var error in result.Errors)
                        {
                        ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                }
            return View();
            }
        [HttpPost]
        public async Task<IActionResult> Login( LoginUserViewModel model )
        {
            if (ModelState.IsValid)
                {
                var user = await _userManager.FindByNameAsync(model.Email);
                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
                    {
                    if (model.RemmberMe)
                        {
                        await _signInManager.SignInAsync(user, isPersistent: true);
                    }
                    else
                        {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        }
                    return RedirectToAction("Index", "Home");
                    }
                }
            return View(model);
            }

        }
    }
