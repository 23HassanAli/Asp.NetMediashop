using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24.Data;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public class OrderService : IOrdersService
    {
        private readonly AppDbContext _context;
        public OrderService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Laptop).Include(u => u.User).ToListAsync();

            if (userRole != "Admin")
            {
                orders = orders.Where(n => n.UserId == userId).ToList();
            }

            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            if(userId != null && userEmailAddress != null) 
            {
                var order = new Order()
                {
                    UserId = userId,
                    Email = userEmailAddress
                };
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();

                foreach (var item in items)
                {
                    var orderItem = new OrderItem()
                    {
                        Amount = item.Amount,
                        LaptopId = item.Laptop.Id,
                        OrderId = order.Id,
                        Price = item.Laptop.Price
                    };
                    await _context.OrderItems.AddAsync(orderItem);
                }
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
