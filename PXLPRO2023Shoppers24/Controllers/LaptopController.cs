using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
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
        public async Task<IActionResult> Index()
        {
            var laptops = await _laptopService.GetAllAsync();  
            return View(laptops);

        }
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
            return RedirectToAction(nameof(Index));
        }
    }
}