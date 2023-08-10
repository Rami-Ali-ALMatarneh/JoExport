using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFutureAdvannced.Models.IRepository;
using ProjectFutureAdvannced.Models.Model.AccountUser;
using ProjectFutureAdvannced.ViewModels;

namespace ProjectFutureAdvannced.Controllers
    {
    public class UserController : Controller
        {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUserRepository userRepository;
        public UserController( IUserRepository userRepository, UserManager<Account> userManager, SignInManager<Account> signInManager, RoleManager<IdentityRole> _roleManager )
            {
            _userManager = userManager;
            _signInManager = signInManager;
            this._roleManager = _roleManager;
            this.userRepository= userRepository;
            }
        public IActionResult Index()
            {
            return View();
            }
 
        }
    }
