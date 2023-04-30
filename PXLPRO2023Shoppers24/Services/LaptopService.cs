using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24.Data;
using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using System.Linq.Expressions;

namespace PXLPRO2023Shoppers24.Services
{
    public class LaptopService : EntityBaseRepository<Laptop>, ILaptopService
    {
        private readonly AppDbContext _appDbContext;
        public LaptopService(AppDbContext options) : base(options)
        {
            _appDbContext = options;
        }
        //public Laptop this[string name] => throw new NotImplementedException();
        public async Task AddNewLaptopAsync(NewLaptopVM t)
        {
            var newLaptop = new Laptop()
            {
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

        //public async Task AddAsync(Laptop t)
        //{
        //    var newLaptop = new Laptop()
        //    {
        //        Name = t.Name,
        //        Price = t.Price,
        //        Description = t.Description,
        //        StockQuantity = t.StockQuantity,
        //        ImageURL = t.ImageURL,
        //        ProductCategory = t.ProductCategory,
        //        Brand = t.Brand,
        //        Color = t.Color,
        //        Processor = t.Processor,
        //        ScreenSize = t.ScreenSize,
        //        InternalRAM = t.InternalRAM,
        //        TotalStorageCapacity= t.TotalStorageCapacity,
        //        Touchscreen = t.Touchscreen,    
        //        VideoCard = t.VideoCard,    
        //    };
        //    await  _appDbContext.Laptops.AddAsync(newLaptop);
        //    await _appDbContext.SaveChangesAsync();
        //}

        //public async Task AddNewLaptopAsync(NewLaptopVM t)
        //{
        //    var newLaptop = new Laptop()
        //    {
        //        Name = t.Name,
        //        Price = t.Price,
        //        Description = t.Description,
        //        StockQuantity = t.StockQuantity,
        //        ImageURL = t.ImageURL,
        //        ProductCategory = t.ProductCategory,
        //        Brand = t.Brand,
        //        Color = t.Color,
        //        Processor = t.Processor,
        //        ScreenSize = t.ScreenSize,
        //        InternalRAM = t.InternalRAM,
        //        TotalStorageCapacity = t.TotalStorageCapacity,
        //        Touchscreen = t.Touchscreen,
        //        VideoCard = t.VideoCard,
        //    };
        //    await _appDbContext.Laptops.AddAsync(newLaptop);
        //    await _appDbContext.SaveChangesAsync();
        //}

        //public Task DeleteAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task DeleteLaptopAsync(int id)
        //{
        //    var result = await _appDbContext.Laptops.FirstOrDefaultAsync(n => n.Id == id);
        //    _appDbContext.Laptops.Remove(result);
        //    await _appDbContext.SaveChangesAsync();
        //}

        //public async Task<IEnumerable<Laptop>> GetAllAsync()
        //{
        //    var laptops = await _appDbContext.Laptops.ToListAsync();
        //    return laptops;
        //}

        //public Task<IEnumerable<Laptop>> GetAllAsync(params Expression<Func<Laptop, object>>[] includeProperties)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Laptop> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<Laptop> GetLaptopByIdAsync(int id)
        //{
        //    var laptopDetails = await _appDbContext.Laptops
        //        .FirstOrDefaultAsync(n => n.Id == id);
        //    return laptopDetails;
        //}

        //public Task UpdateAsync(int id, Laptop entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task UpdateLaptopAsync(Laptop data)
        //{
        //    _appDbContext.ChangeTracker.Clear();
        //    _appDbContext.Laptops.Update(data);
        //    _appDbContext.SaveChanges();    
        //    return Task.CompletedTask;
        //}
    }
}
