using PXLPRO2023Shoppers24.Models;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Laptop Laptop { get; set; }  
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
