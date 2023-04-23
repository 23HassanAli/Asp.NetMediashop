using PXLPRO2023Shoppers24.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PXLPRO2023Shoppers24.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
        public string ImageURL { get; set; }
        public ProductCategory ProductCategory { get; set; }

        [ForeignKey("LaptopId")]
        public int LaptopId { get; set; } 
        [ForeignKey("GsmId")]
        public int GsmId { get; set; }
    


    }
}
