using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels;
using ProjectFutureAdvannced.ViewModels.AdminViewModel;

namespace ProjectFutureAdvannced.Controllers
    {
    public class AdminController : Controller
        {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminRepository adminRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController( IWebHostEnvironment webHostEnvironment, IAdminRepository adminRepository, UserManager<Account> userManager, SignInManager<Account> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = _roleManager;
            this.adminRepository = adminRepository;
            this.webHostEnvironment = webHostEnvironment;
            }
        [AllowAnonymous]
        public IActionResult Index()
            {

            return View();
            }
        public IActionResult table()
            {
            return View();
            }
        [HttpGet]
        public async Task<IActionResult> GeneralProfile()
            {
            ListOfInfoAdmin model;
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
                {
                var admin = adminRepository.GetByFK(user.Id);
                model = new ListOfInfoAdmin()
                    {
                    GeneralInfoAdmin = new GeneralInfoAdmin()
                        {
                        Name = admin.Name,
                        Email = admin.Email,
                        TypeOfRoles = admin.TypeOfRoles,
                        UrlImgString = admin.ImgUrl,
                        }
                    };
                return View(model);
                }
            return RedirectToAction("Index", "Home");
            }
        /*************************************/
        [HttpPost]
        public async Task<IActionResult> GeneralProfile( GeneralInfoAdmin admin )
            {
            if (ModelState.IsValid)
                {
                if (admin.ImgUser != null)
                    {
                    var folder = "/AccountImg/";
                    folder += admin.ImgUser.FileName + "_" + Guid.NewGuid().ToString();
                    admin.UrlImgString = folder;
                    string ServerFolder = Path.Combine(webHostEnvironment.WebRootPath, folder);
                    await admin.ImgUser.CopyToAsync(new FileStream(ServerFolder, FileMode.Create));
                    }
                /*********************/
                int indexOfAt = admin.Email.IndexOf("@");
                var user = await _userManager.GetUserAsync(User);
                user.Name = admin.Name;
                user.UserName = admin.Email.Substring(0, indexOfAt - 1);
                user.Email = admin.Email;
                /*************************/
                Admin admin1 = new Admin()
                    {
                    Name = admin.Name,
                    Email = admin.Email,
                    TypeOfRoles = admin.TypeOfRoles,
                    ImgUrl = admin.UrlImgString,
                    };
                adminRepository.Update(admin1);
                await _userManager.UpdateAsync(user);
                ListOfInfoAdmin listOfInfoAdmin = new ListOfInfoAdmin()
                    {
                    GeneralInfoAdmin=new GeneralInfoAdmin()
                        {
                        Name = admin.Name,
                        Email=admin.Email,
                        TypeOfRoles = admin.TypeOfRoles,
                        UrlImgString= admin.UrlImgString,
                        }
                    };
                return View(listOfInfoAdmin);
                }
            return View();
            }
        /***********************************/
        [HttpGet]
        public  IActionResult SecurityAdmin()
            {
            return View();
            }
        [HttpPost]
        public async Task<IActionResult> SecurityAdmin(SecurityAdmin security)
            {
            if (ModelState.IsValid)
                {
                var user=await _userManager.GetUserAsync(User);
                if (user != null)
                    {
                       if(await _userManager.CheckPasswordAsync(user, security.CurrentPassword))
                        {
                       var changePassword= await _userManager.ChangePasswordAsync(user,security.CurrentPassword, security.NewPassword);
                        if (changePassword.Succeeded)
                            {
                            await _signInManager.RefreshSignInAsync(user);
                            return RedirectToAction("SecurityAdmin", "Admin");
                            }
                        else
                            {
                            foreach (var error in changePassword.Errors)
                                {
                                ModelState.AddModelError("", error.Description);
                                }
                            return View(security);
                            }
                        }
                    }
                }
            return View();
            }
        }
    }


