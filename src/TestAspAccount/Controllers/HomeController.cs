using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using TestAspAccount.Models;
using Microsoft.Extensions.DependencyInjection;

namespace TestAspAccount.Controllers
{
    public class HomeController : Controller
    {

        private IServiceProvider _serviceProvider;
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signManager;

        protected UserManager<ApplicationUser> UserManager
        {
            get
            {
                if (_userManager == null) _userManager = ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                return _userManager;
            }
        }


        protected SignInManager<ApplicationUser> SigninManager
        {
            get
            {
                if (_signManager == null) _signManager = ServiceProvider.GetRequiredService<SignInManager<ApplicationUser>>();
                return _signManager;
            }
        }

        protected IServiceProvider ServiceProvider
        {
            get { return _serviceProvider; }
        }

        public HomeController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }


        public IActionResult Index()
        {



            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
