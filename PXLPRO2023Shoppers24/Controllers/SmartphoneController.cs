using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Services;

namespace PXLPRO2023Shoppers24.Controllers
{
    public class SmartphoneController : Controller
    {
        private readonly ISmartphoneService _smartphoneService;
        public SmartphoneController(ISmartphoneService smartphoneService)
        {
            _smartphoneService = smartphoneService;
        }
        public async Task<IActionResult> Index()
        {
            var smartphones = await _smartphoneService.GetAllAsync();
            return View(smartphones);

        }
        public async Task<IActionResult> Details(int id)
        {
            var smartphoneDetail = await _smartphoneService.GetByIdAsync(id);
            return View(smartphoneDetail);
        }

        //GET: Smartphone/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewSmartphoneVM sm)
        {
            if (!ModelState.IsValid)
            {
                return View(sm);
            }
            await _smartphoneService.AddNewSmartphoneAsync(sm);
            return RedirectToAction(nameof(Index));
        }

        //GET: Smartphone/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var laptopDetail = await _smartphoneService.GetByIdAsync(id);
            if (laptopDetail == null) return View("NotFound");
            return View(laptopDetail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Smartphone smartphone)
        {
            if (id != smartphone.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                return View(smartphone);
            }
            await _smartphoneService.UpdateAsync(id, smartphone);
            return RedirectToAction(nameof(Index));

        }
        //GET: smartphone/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var smartphoneDetails = await _smartphoneService.GetByIdAsync(id);
            if (smartphoneDetails == null) return View("NotFound");

            return View(smartphoneDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var smartphoneDetails = await _smartphoneService.GetByIdAsync(id);
            if (smartphoneDetails == null) return View("NotFound");

            await _smartphoneService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
