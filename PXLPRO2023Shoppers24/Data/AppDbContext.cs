using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24.Models;
using PXLPRO2023Shoppers24.Data.ViewModels;
using eTickets.Models;

namespace PXLPRO2023Shoppers24.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product > Products { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Smartphone> Smartphones { get; set; }    
        public DbSet<PXLPRO2023Shoppers24.Data.ViewModels.LaptopEditVM>? LaptopEditVM { get; set; }
        public DbSet<PXLPRO2023Shoppers24.Data.ViewModels.NewSmartphoneVM>? NewSmartphoneVM { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
