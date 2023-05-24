using MediaShopApi.Data.ViewModels;
using MediaShopApi.Models;

namespace MediaShopApi.Repository
{
    public interface ILaptopRepository
    {
        Task<Laptop> GetLaptopByIdAsync(int id);
        Task<IEnumerable<Laptop>> GetAllAsync();
        Task AddNewLaptopAsync(NewLaptopVM data);
        void UpdateLaptopAsync(Laptop data);
        void DeleteLaptop(Laptop laptop);
    }
}
