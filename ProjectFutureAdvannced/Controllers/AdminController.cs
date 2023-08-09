using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IAdminRepository adminRepository;
        public AdminController( IAdminRepository adminRepository, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            _userManager = userManager;
            _signInManager = signInManager;
            this._roleManager = _roleManager;
            this.adminRepository= adminRepository;
            }

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
