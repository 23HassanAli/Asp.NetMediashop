using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;

namespace PXLPRO2023Shoppers24.Services
{
    public interface ISmartphoneService : IEntityBaseRepository<Smartphone>
    {
        Task AddNewSmartphoneAsync(NewSmartphoneVM data);
    }
}
