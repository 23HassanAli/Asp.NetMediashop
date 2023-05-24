namespace MediaShopApi.Models
{
    public class LaptopOutModel
    {
        public LaptopOutModel(int id, string laptopId, string name, double price, string description, int stockQuantity, string imageURL, string productCategory, string brand, string color, string processor, string screenSize, int internalRAM, int totalStorageCapacity, bool touchscreen, string videoCard)
        {
            Id = id;
            LaptopId = laptopId;
            Name = name;
            Price = price;
            Description = description;
            StockQuantity = stockQuantity;
            ImageURL = imageURL;
            ProductCategory = productCategory;
            Brand = brand;
            Color = color;
            Processor = processor;
            ScreenSize = screenSize;
            InternalRAM = internalRAM;
            TotalStorageCapacity = totalStorageCapacity;
            Touchscreen = touchscreen;
            VideoCard = videoCard;
        }

        public int Id { get; set; }
        public string LaptopId { get; set; }
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
