using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
    {
    public class AccountController : Controller
        {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminRepository adminRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IUserRepository userRepository;

        public AccountController( IAdminRepository adminRepository, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            _userManager = userManager;
            _signInManager = signInManager;
            this._roleManager = _roleManager;
            this.adminRepository = adminRepository;
            }

        public IActionResult Index()
            {

            return View();
            }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Create()
            {
            return View();
            }
        [AllowAnonymous]

        [HttpPost]
        public async Task<IActionResult> Create( RegisterViewModel model )
            {
            if (ModelState.IsValid)
                {
                int indexOfAt = model.Email.IndexOf("@");
                IdentityUser user = new IdentityUser
                    {
                    Email = model.Email,
                    UserName = model.Email.Substring(0, indexOfAt - 1),
                    };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    {
                    // Add the roles you want to assign to the user

                    // Check if the role exists before adding
                    if(model.TypeOfRoles==TypeOfUser.Admin)
                        {
                        if (await _roleManager.RoleExistsAsync("Admin"))
                        {
                        await _userManager.AddToRoleAsync(user, "Admin");
                        }
                        Admin admin = new Admin()
                            {
                            Name = model.Name,
                            Email = model.Email,
                            Password = model.Password,
                            ConfirmPassword = model.ConfirmPassword,
                            TypeOfRoles= model.TypeOfRoles,
                            UserId = user.Id,
                            };
                        adminRepository.Add(admin);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Admin", "index");
                        }
                    else
                    if (model.TypeOfRoles == TypeOfUser.Shop)
                        {
                        if (await _roleManager.RoleExistsAsync("Shop"))
                            {
                            await _userManager.AddToRoleAsync(user, "Shop");
                            }
                        Shop shop = new Shop()
                            {
                            Name = model.Name,
                            Email = model.Email,
                            Password = model.Password,
                            ConfirmPassword = model.ConfirmPassword,
                            TypeOfRoles = model.TypeOfRoles,
                            UserId = user.Id,
                            };
                        _shopRepository.Add(shop);
                        }
                    else
                    if (model.TypeOfRoles == TypeOfUser.User)
                        {
                        if (await _roleManager.RoleExistsAsync("User"))
                            {
                            await _userManager.AddToRoleAsync(user, "User");
                            }
                        User users = new User()
                            {
                            Name = model.Name,
                            Email = model.Email,
                            Password = model.Password,
                            ConfirmPassword = model.ConfirmPassword,
                            TypeOfRoles = model.TypeOfRoles,
                            UserId = user.Id,
                            };
                        userRepository.Add(users);
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
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
            {
            return View();
            }
        [AllowAnonymous]

        [HttpPost]
        public async Task<IActionResult> Login( LoginViewModel model )
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
