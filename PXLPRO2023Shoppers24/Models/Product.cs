using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PXLPRO2023Shoppers24.Models
{

    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; } 

    }
}
