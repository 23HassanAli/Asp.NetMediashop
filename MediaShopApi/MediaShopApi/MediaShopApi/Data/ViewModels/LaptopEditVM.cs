using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MediaShopApi.Data.ViewModels
{
    public class LaptopEditVM
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public int StockQuantity { get; set; }

        public string ImageURL { get; set; }
        public string ProductCategory { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public string Processor { get; set; }

        public string ScreenSize { get; set; }

        public int InternalRAM { get; set; }

        public int TotalStorageCapacity { get; set; }

        public bool Touchscreen { get; set; }
        public string VideoCard { get; set; }
    }
}
