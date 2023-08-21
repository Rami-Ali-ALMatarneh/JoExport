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
            GeneralInfoAdmin model;
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
                {
                var admin = adminRepository.GetByFK(user.Id);
                
                model = new GeneralInfoAdmin()
                    {
                    Name = admin.Name,
                    Email = admin.Email,
                    UrlImgString = user.ImgUrl,
                    PhoneNumber = admin.PhoneNumber,
                    Gender = user.Gender,
                    Birthday =admin.Birthday,
                    Major=user.Major,
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
                var user = await _userManager.GetUserAsync(User);
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
                user.Name = admin.Name;
                user.ImgUrl = admin.UrlImgString;
                user.UserName = admin.Email.Substring(0, indexOfAt);
                user.Email = admin.Email;
                /*************************/
                var admin1= adminRepository.GetByFK(user.Id);   
                admin1.Name= admin.Name;
                admin1.Email= admin.Email;
                user.Gender=admin.Gender;
                admin1.PhoneNumber=admin.PhoneNumber;
                admin1.Birthday=admin.Birthday;
                user.Major = admin.Major;
                adminRepository.Update(admin1);
                await _userManager.UpdateAsync(user);
                GeneralInfoAdmin model = new GeneralInfoAdmin()
                    {
                        Name = admin.Name,
                        Email = admin.Email,
                        UrlImgString = admin.UrlImgString,
                        PhoneNumber = admin.PhoneNumber,
                        Gender = admin.Gender,
                        Birthday = admin.Birthday,
                        Major=admin.Major,
                    };
                return View(model);
                }
            return View();
            }
        /***********************************/
        [HttpGet]
        public async Task<IActionResult> SecurityAdmin()
            {
            var user=await _userManager.GetUserAsync(User);
            var admin = adminRepository.GetByFK(user.Id);
            SecurityAdmin security = new SecurityAdmin();
            return View(security);
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
                            Admin admin = new Admin();
                            admin.Password = security.NewPassword;
                            admin.ConfirmPassword = security.ConfirmNewPassword;
                            adminRepository.Update(admin);
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

        /***********************************/

        }
    }


