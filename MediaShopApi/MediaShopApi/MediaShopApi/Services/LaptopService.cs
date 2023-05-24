using MediaShopApi.Data;
using MediaShopApi.Data.ViewModels;
using MediaShopApi.Models;
using MediaShopApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MediaShopApi.Services
{
    public class LaptopService : ILaptopRepository
    {
        private readonly AppDbContext _appDbContext;
        public LaptopService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
  
        public async Task AddNewLaptopAsync(NewLaptopVM t)
        {
            var newLaptop = new Laptop()
            {
                LaptopId = t.LaptopId,
                Name = t.Name,
                Price = t.Price,
                Description = t.Description,
                StockQuantity = t.StockQuantity,
                ImageURL = t.ImageURL,
                ProductCategory = t.ProductCategory,
                Brand = t.Brand,
                Color = t.Color,
                Processor = t.Processor,
                ScreenSize = t.ScreenSize,
                InternalRAM = t.InternalRAM,
                TotalStorageCapacity = t.TotalStorageCapacity,
                Touchscreen = t.Touchscreen,
                VideoCard = t.VideoCard,
            };
            await _appDbContext.Laptops.AddAsync(newLaptop);
            await _appDbContext.SaveChangesAsync();
        }
        [HttpDelete("{id}")]
        public void DeleteLaptop(Laptop laptop)
        {
            _appDbContext.Laptops.Remove(laptop);
            _appDbContext.SaveChanges();    
        }

        public async Task<IEnumerable<Laptop>> GetAllAsync()
        {
            var laptops = await _appDbContext.Laptops.ToListAsync();
            return laptops;
        }
        
        public Task<Laptop> GetLaptopByIdAsync(int id)
        {
            var laptopId = id.ToString();
            return _appDbContext.Laptops.FirstOrDefaultAsync(l => l.LaptopId == laptopId);
        }
  
        public void UpdateLaptopAsync(Laptop data)
        {
            _appDbContext.Laptops.Update(data);
            _appDbContext.SaveChanges();
        }
    }
}
