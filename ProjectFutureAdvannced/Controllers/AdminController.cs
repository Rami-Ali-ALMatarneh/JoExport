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
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminRepository adminRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public AdminController( IWebHostEnvironment webHostEnvironment, IAdminRepository adminRepository, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> _roleManager )
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
                var admin = adminRepository.GetByFk(user.Id);
                
                model = new GeneralInfoAdmin()
                    {
                    Name = admin.Name,
                    Email = admin.Email,
                    UrlImgString = user.ImgUrl,
                    PhoneNumber = admin.PhoneNumber,
                    Gender = admin.Gender,
                    Major=admin.Major,
                    };
                return View(model);
                }
            return View();
            }
        /*************************************/
        [HttpPost]
        public async Task<IActionResult> GeneralProfile( GeneralInfoAdmin model )
            {
            if (ModelState.IsValid)
                {
                string uniqueFileName = null;
                var user = await _userManager.GetUserAsync(User);
                var admin = adminRepository.GetByFk(user.Id);
                if (model.ImgUser != null)
                    {
                    string uniqueUpload = Path.Combine(webHostEnvironment.WebRootPath, "AccountImg");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImgUser.FileName;
                    string filePath = Path.Combine(uniqueUpload, uniqueFileName);
                    await model.ImgUser.CopyToAsync(new FileStream(filePath, FileMode.Create));
                    model.UrlImgString = uniqueFileName;
                    }
                else
                    {
                    if ((user.ImgUrl != null && admin.Gender != null) || (user.ImgUrl == null && admin.Gender != null))
                        {
                        if (model.Gender == "Male")
                            {
                            uniqueFileName = "img_avatar.png";
                            }
                        else
                          if (model.Gender == "Female")
                            {
                            uniqueFileName = "img_avatar2.png";
                            }
                        else
                            {
                            uniqueFileName = user.ImgUrl;
                            }
                        }
                    else
                    if ((user.ImgUrl != null && admin.Gender == null))
                        {
                        uniqueFileName = user.ImgUrl;
                        }
                    model.UrlImgString = uniqueFileName;
                    }

                /*********************/
                int indexOfAt = model.Email.IndexOf("@");
                admin.Name = model.Name;
                user.ImgUrl = model.UrlImgString;
                admin.UserName = model.Email.Substring(0, indexOfAt);
                admin.Email = model.Email;
                /*************************/
                admin.Name= model.Name;
                admin.Email= model.Email;
                admin.Gender=model.Gender;
                admin.PhoneNumber=model.PhoneNumber;
                admin.Major = model.Major;
                adminRepository.Update(admin);
                await _userManager.SetEmailAsync(user, user.Email);
                await _userManager.SetUserNameAsync(user, model.Email.Substring(0, indexOfAt));
                await _userManager.UpdateAsync(user);
                return RedirectToAction("GeneralProfile", "User");
                }
            return View();
            }
        /***********************************/
        [HttpGet]
        public async Task<IActionResult> SecurityAdmin()
            {
            var user=await _userManager.GetUserAsync(User);
            var admin = adminRepository.GetByFk(user.Id);
            SecurityAdmin security = new SecurityAdmin();
            return View(security);
            }
        [HttpPost]
        public async Task<IActionResult> SecurityAdmin(SecurityAdmin security)
            {
            if (ModelState.IsValid)
                {
                var user = await _userManager.GetUserAsync(User);

                if (user != null)
                    {
                    var isCurrentPasswordValid = await _userManager.CheckPasswordAsync(user, security.CurrentPassword);

                    if (isCurrentPasswordValid)
                        {
                        if (security.NewPassword == security.ConfirmNewPassword)
                            {
                            var changePasswordResult = await _userManager.ChangePasswordAsync(user, security.CurrentPassword, security.NewPassword);

                            if (changePasswordResult.Succeeded)
                                {
                                await _signInManager.RefreshSignInAsync(user);
                                return RedirectToAction("SecurityAdmin", "Admin");
                                }
                            else
                                {
                                foreach (var error in changePasswordResult.Errors)
                                    {
                                    ModelState.AddModelError("", error.Description);
                                    }
                                return View(security);
                                }
                            }
                        }
                    else
                        {
                        ModelState.AddModelError("", "Current password is incorrect.");
                        }
                    }
                }

            return View();

            }

        /***********************************/

        }
    }


