using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public interface ILaptopService : IEntityBaseRepository<Laptop>
    {
        Laptop this[string name] { get; }
        Task<Laptop> GetLaptopByIdAsync(int id);

        Task AddNewLaptopAsync(NewLaptopVM data);
        Task UpdateLaptopAsync(NewLaptopVM data);
        Task DeleteLaptopAsync(int id);
    }
}
