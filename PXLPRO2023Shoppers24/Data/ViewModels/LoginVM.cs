using System.ComponentModel.DataAnnotations;

namespace PXLPRO2023Shoppers24.Data.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }   
        [Required(ErrorMessage = "Pssword is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
