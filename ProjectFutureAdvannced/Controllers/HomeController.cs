using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
    {
    [AllowAnonymous]

    public class HomeController : Controller
        {
        private readonly IShopRepository shopRepository;

        private readonly ICategoryRepository categoryRepository;
        public HomeController( ICategoryRepository categoryRepository, IShopRepository shopRepository )
        {
            this.categoryRepository = categoryRepository;
            this.shopRepository = shopRepository;
        }
        public IActionResult Index()
            {
            ListOfInfo listOfInfo = new ListOfInfo()
                {
                //shops = shopRepository.GetAll(),
                categories = categoryRepository.GetAll()
                };
            return View( listOfInfo );
            }
        [HttpGet]
        public IActionResult Login()
            {
            return View();
            }
        [HttpGet]
        public IActionResult SignUp()
            {
            return View();
            }
        }
    }
