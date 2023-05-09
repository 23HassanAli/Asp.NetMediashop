using Microsoft.AspNetCore.Mvc;
using PXLPRO2023Shoppers24.Data.Cart;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Services;

namespace PXLPRO2023Shoppers24.Data.ViewComponents
{
    [ViewComponent(Name = "FeaturedLaptops")]
    public class FeaturedLaptopsViewComponent : ViewComponent
    {
        private readonly ILaptopService _laptopService;
        public FeaturedLaptopsViewComponent(ILaptopService laptopService)
        {
                _laptopService= laptopService;  
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _laptopService.GetAllAsync();
            List<LaptopCardViewModel> laptops = new List<LaptopCardViewModel>();

            foreach (var item in items.Take(4))
            {
                var featuredLaptops = new LaptopCardViewModel(item);
                laptops.Add(featuredLaptops);
            }
            return View(laptops);
        }
    }
}
