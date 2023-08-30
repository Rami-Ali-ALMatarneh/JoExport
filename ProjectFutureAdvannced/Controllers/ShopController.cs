using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels;
using ProjectFutureAdvannced.ViewModels.AdminViewModel;
using ProjectFutureAdvannced.ViewModels.ProductViewModel;
using ProjectFutureAdvannced.ViewModels.UserViewModel;

namespace ProjectFutureAdvannced.Controllers
{
    public class ShopController : Controller
        {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IShopRepository _shopRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly ICardRepository cardRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IProductRepository productRepository;

        public ShopController( IProductRepository productRepository, ICategoryRepository categoryRepository, ICardRepository cardRepository,IWebHostEnvironment webHostEnvironment, IShopRepository _shopRepository, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            _userManager = userManager;
            _signInManager = signInManager;
            this._roleManager = _roleManager;
            this._shopRepository=_shopRepository;
            this.webHostEnvironment=webHostEnvironment;
            this.cardRepository=cardRepository;
            this.categoryRepository = categoryRepository;
            this.productRepository = productRepository;            
            }
        public IActionResult Index()
            {
            return View();
            }
        [HttpGet]
        public async Task<IActionResult> GeneralShopProfile()
            {
            GeneralInfoUser model;
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
                {
                var Shop = _shopRepository.GetByFk(user.Id);

                model = new GeneralInfoUser()
                    {
                    Name = Shop.Name,
                    Email = Shop.Email,
                    UrlImgString = user.ImgUrl,
                    PhoneNumber = Shop.PhoneNumber,
                    Gender = Shop.Gender,
                    Major = Shop.Major,
                    };
                return View(model);
                }
            return View();
            }
        /*************************************/
        [HttpPost]

        public async Task<IActionResult> GeneralShopProfile( GeneralInfoUser Shop )
            {
            if (ModelState.IsValid)
                {
                string uniqueFileName = null;
                var user = await _userManager.GetUserAsync(User);
                var shop = _shopRepository.GetByFk(user.Id);
                if (Shop.ImgUser != null)
                    {
                    string uniqueUpload = Path.Combine(webHostEnvironment.WebRootPath, "AccountImg");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + Shop.ImgUser.FileName;
                    string filePath = Path.Combine(uniqueUpload, uniqueFileName);
                    await Shop.ImgUser.CopyToAsync(new FileStream(filePath, FileMode.Create));
                    Shop.UrlImgString = uniqueFileName;
                    }
                else
                    {
                    if ((user.ImgUrl != null && Shop.Gender != null) || (user.ImgUrl == null && Shop.Gender != null))
                        {
                        if (Shop.Gender == "Male")
                            {
                            uniqueFileName = "img_avatar.png";
                            }
                        else
                          if (Shop.Gender == "Female")
                            {
                            uniqueFileName = "img_avatar2.png";
                            }
                        else
                            {
                            uniqueFileName = user.ImgUrl;
                            }
                        }
                    else
                    if ((user.ImgUrl != null && Shop.Gender == null))
                        {
                        uniqueFileName = user.ImgUrl;
                        }
                    Shop.UrlImgString = uniqueFileName;
                    }
                /*********************/
                int indexOfAt = Shop.Email.IndexOf("@");
                shop.Name = Shop.Name;
                user.ImgUrl = Shop.UrlImgString;
                shop.UserName = Shop.Email.Substring(0, indexOfAt);
                shop.Email = Shop.Email;
                /*************************/
                shop.Gender = Shop.Gender;
                shop.PhoneNumber = Shop.PhoneNumber;
                shop.Major = Shop.Major;
                _shopRepository.Update(shop);
                await _userManager.SetEmailAsync(user, user.Email);
                await _userManager.SetUserNameAsync(user, shop.Email.Substring(0, indexOfAt));
                await _userManager.UpdateAsync(user);
                return RedirectToAction("GeneralShopProfile", "Shop");
                }
            return View();
            }
        /***********************************/

        [HttpGet]
        public async Task<IActionResult> SecurityUser()
            {
            SecurityUser security = new SecurityUser();
            return View(security);
            }
        [HttpPost]
        public async Task<IActionResult> SecurityUser( SecurityUser security )
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
                                return RedirectToAction("SecurityUser", "Shop");
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
        [HttpGet]
        public IActionResult AddProduct( )
            {
            return View();
            }
       
        public IActionResult DeleteProduct(int id)
            {
            productRepository.Delete(id);
            return View();
            }
        [HttpPost]
        public async Task<IActionResult> AddProduct( CreateProduct model)
            {
         if(ModelState.IsValid)
                {

                string uniqueFileName = null;
                string uniqueUpload = Path.Combine(webHostEnvironment.WebRootPath, "ProductImg");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.formFile.FileName;
                string filePath = Path.Combine(uniqueUpload, uniqueFileName);
                await model.formFile.CopyToAsync(new FileStream(filePath, FileMode.Create));
                model.Image = uniqueFileName;
                //var user = await _userManager.GetUserAsync(User);
                //  var category = categoryRepository.GetByCategoryName(model.CategoryName);
                // var shop = _shopRepository.Get(user.Id);
                Product product = new Product();
                product.Name = model.Name;
                product.Description = model.Description;
                product.CategoryName = model.CategoryName;
                product.Price = Convert.ToDouble(model.Price);
                product.Image = model.Image;
                var user = await _userManager.GetUserAsync(User);
                var shop = _shopRepository.GetByFk(user.Id);
                product.ShopId = shop.Id;
                productRepository.Add(product);
                return RedirectToAction("Index","Home");
                }
            return View();
            }
        public async Task<IActionResult> MyProduct()
            {
            var user = await _userManager.GetUserAsync(User);
            var shop = _shopRepository.GetByFk(user.Id);
            var product = productRepository.Find(x=>x.ShopId==shop.Id);
            return View(product);
            }
        }
    }
