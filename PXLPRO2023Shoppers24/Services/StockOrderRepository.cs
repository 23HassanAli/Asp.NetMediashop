using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public class StockOrderRepository : IStockOrderRepository
    {
        private readonly IStockApiRepository _stockRepository;
        public StockOrderRepository(IStockApiRepository stockRespository)
        {
            _stockRepository = stockRespository;
        }
        public async Task<IEnumerable<StockLaptop>> GetAll()
        {
            return await _stockRepository.GetAll();
        }


        public async Task UpdateLaptop(int id, Laptop laptop)
        {
            _stockRepository.Update(id, laptop);
        }

    }
}
