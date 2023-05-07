using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public interface ILaptopService : IEntityBaseRepository<Laptop>
    {
        //Laptop this[string name] { get; }
        //Task<Laptop> GetLaptopByIdAsync(int id);
        Task<IEnumerable<Laptop>> GetAllAsync();
        Task AddNewLaptopAsync(NewLaptopVM data);
        //Task UpdateLaptopAsync(Laptop data);
        //Task DeleteLaptopAsync(int id);
    }
}
