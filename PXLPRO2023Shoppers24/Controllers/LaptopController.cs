using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Services;
using System.Data;

namespace PXLPRO2023Shoppers24.Controllers
{

    public class LaptopController : Controller
    {
        private readonly ILaptopService _laptopService;
        public LaptopController(ILaptopService laptopService)
        {
            _laptopService = laptopService;
        }
        public IActionResult Test()
        {
            return View();  
        }
        public async Task<IActionResult> Index()
        {
            var laptops = await _laptopService.GetAllAsync();
            return View(laptops);

        }
        public async Task<IActionResult> Details(int id)
        {
            var movieDetail = await _laptopService.GetLaptopByIdAsync(id);
            return View(movieDetail);
        }

        //GET: Laptop/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewLaptopVM laptop)
        {
            if (!ModelState.IsValid)
            {
                return View(laptop);
            }
            await _laptopService.AddNewLaptopAsync(laptop);
            return RedirectToAction(nameof(Index));
        }

    }
}
