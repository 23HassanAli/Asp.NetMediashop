using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Data.ViewModels
{
    public class LaptopCardViewModel
    {
        public LaptopCardViewModel(Laptop laptop)
        {
            Id = laptop.Id;
            Name = laptop.Name;
            ImageURL = laptop.ImageURL;
            Brand = laptop.Brand;
            Price = laptop.Price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Brand { get; set; }
        public double Price { get; }
    }
}
