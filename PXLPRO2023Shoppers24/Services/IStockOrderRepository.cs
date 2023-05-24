using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public interface IStockOrderRepository
    {
        Task UpdateLaptop(int id, Laptop laptop);
        Task<IEnumerable<StockLaptop>> GetAll();

    }
}
