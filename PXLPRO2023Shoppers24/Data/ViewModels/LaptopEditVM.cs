using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PXLPRO2023Shoppers24.Data.ViewModels
{
    public class LaptopEditVM
    {

        public int Id { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Amount")]
        [Required(ErrorMessage = "Amount is required")]
        public int Amount { get; set; }
    }
}
