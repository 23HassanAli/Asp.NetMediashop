using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PXLPRO2023Shoppers24.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly ILaptopService _laptopService;
        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ILaptopService service)
        {
            _logger = logger;
            _userManager = userManager;
            _laptopService = service;
        }
       
        public async Task<IActionResult> Index()
        {
            ViewData["UserId"] = _userManager.GetUserId(this.User);
            var laptops = await _laptopService.GetAllAsync();
            return View(laptops);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}