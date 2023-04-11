using System.ComponentModel.DataAnnotations;

namespace PXLPRO2023Shoppers24.Data.ViewModels
{
    public class RegisterVm
    {
        [Display(Name = "Username")]  
        [Required(ErrorMessage ="Username is required")]
        public string UserName { get; set; }
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
