using MediaShopApi.Data.ViewModels;
using MediaShopApi.Models;
using MediaShopApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
namespace MediaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : Controller
    {
        private readonly ILaptopRepository _laptopRepository;
        public StockController(ILaptopRepository laptopRepository)
        {
            _laptopRepository = laptopRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var laptops = await _laptopRepository.GetAllAsync();
            return Ok(laptops);
        }

        // GET: Laptop/Details/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            Laptop laptop = await _laptopRepository.GetLaptopByIdAsync(id);
            if (laptop == null)
            {
                return NotFound();
            }
            return Ok(laptop);
        }
        [HttpPost]
        public async Task<IActionResult> AddLaptop([FromBody] MediaShopClassLibrary.Models.Laptop laptop)
        {
            NewLaptopVM laptopVM = new NewLaptopVM
            {
                LaptopId = laptop.Id.ToString(),
                Name = laptop.Name,
                Brand = laptop.Brand,
                Price = laptop.Price,
                Description = laptop.Description,
                StockQuantity = laptop.StockQuantity,
                ImageURL = laptop.ImageURL,
                ProductCategory = laptop.ProductCategory,
                Color = laptop.Color,
                Processor = laptop.Processor,
                ScreenSize = laptop.ScreenSize,
                InternalRAM = laptop.InternalRAM,
                TotalStorageCapacity = laptop.TotalStorageCapacity,
                Touchscreen = laptop.Touchscreen,
                VideoCard = laptop.VideoCard,
            };
            await _laptopRepository.AddNewLaptopAsync(laptopVM);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLaptop(int id, [FromBody] MediaShopClassLibrary.Models.Laptop laptop)
        {
            Laptop laptopinDatabase = await _laptopRepository.GetLaptopByIdAsync(laptop.Id);
            if (laptopinDatabase == null)
            {
                return NotFound();
            }
            Laptop model = new Laptop
            {
                Id= laptop.Id,
                LaptopId = laptop.Id.ToString(),
                Name = laptop.Name,
                Brand = laptop.Brand,
                Price = laptop.Price,
                Description = laptop.Description,
                StockQuantity= laptop.StockQuantity,
                ImageURL = laptop.ImageURL,
                ProductCategory = laptop.ProductCategory,
                Color = laptop.Color,
                Processor = laptop.Processor,
                ScreenSize = laptop.ScreenSize,
                InternalRAM = laptop.InternalRAM,
                TotalStorageCapacity= laptop.TotalStorageCapacity,
                Touchscreen = laptop.Touchscreen,
                VideoCard= laptop.VideoCard,
            };
            _laptopRepository.UpdateLaptopAsync(model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLaptop(int id)
        {
            Laptop laptop = await _laptopRepository.GetLaptopByIdAsync(id);
            if (laptop == null)
            {
                return NotFound();
            }
            _laptopRepository.DeleteLaptop(laptop);
            return Ok();
        }
    }
}
