using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.Enums;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.ViewModels;
using ProjectFutureAdvannced.ViewModels.ProductViewModel;

namespace ProjectFutureAdvannced.Controllers
    {
    [AllowAnonymous]

    public class HomeController : Controller
        {
        private readonly IShopRepository shopRepository;
        private readonly IProductRepository productRepository;

        private readonly ICategoryRepository categoryRepository;
        public HomeController( IProductRepository productRepository, ICategoryRepository categoryRepository, IShopRepository shopRepository )
        {
            this.categoryRepository = categoryRepository;
            this.shopRepository = shopRepository;
            this.productRepository = productRepository;
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
        public IActionResult Category()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Store()
            {
            var product = productRepository.GetAll();
            return View(product);
            }
        public IActionResult Details( int id )
            {
            var Product = productRepository.GetById(id);
            ProductViewModel productViewModel = new ProductViewModel()
                {
                Name = Product.Name,
                Description = Product.Description,
                CategoryName = Product.CategoryName,
                Price = Product.Price,
                Image = Product.Image,
                };
            return View( productViewModel );
            }
        }
    }
