using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using System;

namespace PXLPRO2023Shoppers24.Services
{
    public interface IStockApiRepository
    {
        Task<IEnumerable<StockLaptop>> GetAll();
        Laptop GetById(long id);
        void Add(Laptop laptop);
        void Update(int id, Laptop laptop);
        void Delete(Laptop laptop);
        //IEnumerable<Laptop> GetByDepartment(long departmentId);
    }
}
