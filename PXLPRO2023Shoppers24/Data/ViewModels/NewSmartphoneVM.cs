using PXLPRO2023Shoppers24.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PXLPRO2023Shoppers24.Data.ViewModels
{
    public class NewSmartphoneVM
    {
        [Key]
        public int SmartphoneId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]

        public double Price { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "Stock Quantity")]
        [Required(ErrorMessage = "Stock quantity is required")]
        public int StockQuantity { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image url is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category is required")]
        public ProductCategory ProductCategory { get; set; }
        [Display(Name = "Type")]
        [Required(ErrorMessage = "Type Name is required")]
        public string Type { get; set; }
        [Display(Name = "Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }
        [Display(Name = "Year introduced")]
        [Required(ErrorMessage = "Year introduced is required")]
        public int IntroducedYear { get; set; }
        [Display(Name = "Introduction month")]
        [Required(ErrorMessage = "Introduction month is required")]
        public string IntroductionMonth { get; set; }
        [Display(Name = "Operating system")]
        [Required(ErrorMessage = "Operating system is required")]
        public string OperatingSystem { get; set; }
        [Display(Name = "Height")]
        [Required(ErrorMessage = "Height is required")]
        public string Height { get; set; }
        [Display(Name = "Width")]
        [Required(ErrorMessage = "Width is required")]
        public string Width { get; set; }
        [Display(Name = "Weight")]
        [Required(ErrorMessage = "Weight is required")]
        public string Weight { get; set; }
        [Display(Name = "Color")]
        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }
        [Display(Name = "Water resistant")]
        [Required(ErrorMessage = "Water resistant is required")]
        public bool WaterResistant { get; set; }
        [Display(Name = "Total storage capacity")]
        [Required(ErrorMessage = "Total storage capacity is required")]
        public double TotalStorageCapacity { get; set; }
        [Display(Name = "Internal ram")]
        [Required(ErrorMessage = "Internal ram is required")]
        public double InternalRAM { get; set; }
        [Display(Name = "Total rear cameras")]
        [Required(ErrorMessage = "Total rear cameras is required")]
        public int TotalRearCameras { get; set; }
        [Display(Name = "Total number of megapixles")]
        [Required(ErrorMessage = "Total number of megapixles is required")]
        public int TotalNumberOfMegapixels { get; set; }
        [Display(Name = "Screen Size")]
        [Required(ErrorMessage = "Screen size is required")]
        public string ScreenSize { get; set; }
    }
}
