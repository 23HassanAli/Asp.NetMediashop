using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;

namespace PXLPRO2023Shoppers24.Models
{
    public class Laptop : IEntityBase
    {
        [Key]
        public int Id  { get; set; }
        [Display(Name = "Laptop Name")]
        [Required(ErrorMessage = "Laptop Name is required")]
        public string Name { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Fullname is required")]
        public double Price { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Display(Name = "StockQuantity")]
        [Required(ErrorMessage = "Stock Quantity is required")]
        public int StockQuantity { get; set; }
        [Display(Name = "ImageURL")]
        [Required(ErrorMessage = "Image url is required")]
        public string ImageURL { get; set; }
        [Display(Name = "Product Category ")]
        [Required(ErrorMessage = "Product category is required")]
        public ProductCategory ProductCategory { get; set; }
        [Display(Name = "Brand")]
        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }
        [Display(Name = "Color")]
        [Required(ErrorMessage = "Color is required")]
        public string  Color { get; set; }
        [Display(Name = "Processor")]
        [Required(ErrorMessage = "Processor is required")]
        public string Processor { get; set; }
        [Display(Name = "Screen Size")]
        [Required(ErrorMessage = "Secreen size is required")]
        public string ScreenSize { get; set; }
        [Display(Name = "Internal RAM")]
        [Required(ErrorMessage = "Internal RAM is required")]
        public int InternalRAM { get; set; }
        [Display(Name = "Total Storage Capacity")]
        [Required(ErrorMessage = "Total Storage Capcity is required")]
        public int TotalStorageCapacity { get; set; }
        [Display(Name = "Touch screen")]
        [Required(ErrorMessage = "Touch screen is required")]
        public bool Touchscreen { get; set; }
        [Display(Name = "Video card")]
        [Required(ErrorMessage = "Video card is required")]
        public string VideoCard { get; set; }

 
    }
}
