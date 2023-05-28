using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;
using System.Data;
using System.Security.Claims;

namespace PXLPRO2023Shoppers24.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LaptopController : Controller
    {
        private readonly ILaptopService _laptopService;
        private readonly IStockApiRepository _stockRepository;
        public LaptopController(ILaptopService laptopService, IStockApiRepository stockRepository)
        {
            _laptopService = laptopService;
            _stockRepository = stockRepository;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userRole = User.FindFirstValue(ClaimTypes.Role);


            var laptops = await _laptopService.GetAllAsync();
            if (laptops == null) return View();
            return View(laptops);

        }
        public async Task<IActionResult> Laptops()
        {
            var stockLaptops = await _stockRepository.GetAll();
            var laptops = await _laptopService.GetAllAsync();
            var laptopList = new List<Laptop>();
            foreach (var l in stockLaptops)
            {
                foreach (var item in laptops)
                {
                    if (item.Id == int.Parse(l.LaptopId))
                    {
                        laptopList.Add(item);
                    }
                }
            }
            return View(laptopList);

        }
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var laptopDetail = await _laptopService.GetByIdAsync(id);
            return View(laptopDetail);
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
            var allLaptops = await _laptopService.GetAllAsync();
            var thisLaptop = allLaptops.Last();
            _stockRepository.Add(thisLaptop);
            return RedirectToAction(nameof(Index));
        }

        //GET: Laptop/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var laptopDetail = await _laptopService.GetByIdAsync(id);
            if (laptopDetail == null) return View("NotFound");
            return View(laptopDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Laptop laptop)
        {
            if (id != laptop.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                return View(laptop);
            }
            await _laptopService.UpdateAsync(id, laptop);
            _stockRepository.UpdateLaptop(id, laptop);
            return RedirectToAction(nameof(Index));

        }
        //GET: laptop/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var laptopDetails = await _laptopService.GetByIdAsync(id);
            if (laptopDetails == null) return View("NotFound");

            return View(laptopDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var laptopDetails = await _laptopService.GetByIdAsync(id);
            if (laptopDetails == null) return View("NotFound");

            await _laptopService.DeleteAsync(id);
             _stockRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}