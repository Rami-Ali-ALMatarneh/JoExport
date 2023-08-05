using Microsoft.AspNetCore.Mvc;

namespace ProjectFutureAdvannced.Controllers
    {
    public class UserController : Controller
        {
        public IActionResult Index()
            {
            return View();
            }
        }
    }
