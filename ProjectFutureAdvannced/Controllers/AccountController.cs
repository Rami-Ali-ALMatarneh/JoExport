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
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminRepository adminRepository;
        private readonly IShopRepository _shopRepository;
        private readonly IUserRepository userRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AccountController( IShopRepository _shopRepository, IUserRepository userRepository,IWebHostEnvironment webHostEnvironment, IAdminRepository adminRepository, UserManager<Account> userManager, SignInManager<Account> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = _roleManager;
            this.adminRepository = adminRepository;
            this.webHostEnvironment = webHostEnvironment;
            this._shopRepository = _shopRepository;
            this.userRepository = userRepository;
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
        [HttpGet]
        public async Task<IActionResult> CreateAdmin()
            {
            return View();
            }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateAdmin( RegisterAdminViewModel model )
            {
            if (ModelState.IsValid)
                {
                int indexOfAt = model.Email.IndexOf("@");
                Account user = new Account
                    {
                    Name = model.Name,
                    Email = model.Email,
                    UserName = model.Email.Substring(0, indexOfAt),
                    };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
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
                            UserId = user.Id,
                            };
                        adminRepository.Add(admin);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Admin");
                        }
                    }
            return View();
            }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create( RegisterViewModel model )
            {
            if (ModelState.IsValid)
                {
                int indexOfAt = model.Email.IndexOf("@");
                Account user = new Account
                    {
                    Name=model.Name,
                    Email = model.Email,
                    UserName = model.Email.Substring(0, indexOfAt ),
                    };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    {
                    // Add the roles you want to assign to the user
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
        public async Task<IActionResult> Login( LoginViewModel model, string returnUrl = null )
            {
            if (ModelState.IsValid)
                {
                var user = await _userManager.FindByEmailAsync(model.Email);
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
                    if (Url.IsLocalUrl(returnUrl) && !string.IsNullOrEmpty(returnUrl))
                        {
                        return LocalRedirect(returnUrl);
                        }
                    return RedirectToAction("Index", "Home");
                    }
                }
            return View(model);
            }
        [Authorize]
        public async Task<IActionResult> Logout()
            {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
            }
        [HttpGet]
        public IActionResult Profile()
            {
            return View();
            }
        }
    }
