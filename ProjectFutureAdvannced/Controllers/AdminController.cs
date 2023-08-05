using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
{
    public class AdminController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult table()
        {
            return View();
        }
    }
}
