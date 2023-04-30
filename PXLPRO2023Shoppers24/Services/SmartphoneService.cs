using PXLPRO2023Shoppers24.Data;
using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public class SmartphoneService : EntityBaseRepository<Smartphone>, ISmartphoneService
    {
        private readonly AppDbContext _appDbContext;
        public SmartphoneService(AppDbContext options) : base(options)
        {
            _appDbContext = options;
        }

        public async Task AddNewSmartphoneAsync(NewSmartphoneVM data)
        {
            var newSmartphone = new Smartphone()
            {
                Id = data.SmartphoneId,
                Name = data.Name,
                Price = data.Price,
                Description = data.Description,
                StockQuantity= data.StockQuantity,  
                ImageURL= data.ImageURL,    
                ProductCategory = Models.Enums.ProductCategory.Smartphone,
                Type= data.Type,
                Brand= data.Brand,  
                IntroducedYear = data.IntroducedYear,
                IntroductionMonth = data.IntroductionMonth,
                OperatingSystem = data.OperatingSystem, 
                Height = data.Height,
                Width = data.Width,
                Weight= data.Weight,    
                Color  = data.Color,    
                WaterResistant = data.WaterResistant,   
                TotalStorageCapacity = data.TotalStorageCapacity,
                InternalRAM = data.InternalRAM,
                TotalRearCameras = data.TotalRearCameras,
                TotalNumberOfMegapixels = data.TotalNumberOfMegapixels,
                ScreenSize = data.ScreenSize

            };
            await _appDbContext.Smartphones.AddAsync(newSmartphone);
            await _appDbContext.SaveChangesAsync(); 
        }
    }
}
