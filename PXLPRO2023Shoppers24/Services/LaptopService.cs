using Microsoft.EntityFrameworkCore;
using PXLPRO2023Shoppers24.Data;
using PXLPRO2023Shoppers24.Data.Base;
using PXLPRO2023Shoppers24.Data.ViewModels;
using PXLPRO2023Shoppers24.Models;
using System.Linq.Expressions;

namespace PXLPRO2023Shoppers24.Services
{
    public class LaptopService : EntityBaseRepository<Laptop>, ILaptopService
    {
        private readonly AppDbContext _appDbContext;
        public LaptopService(AppDbContext options) : base(options)
        {
            _appDbContext = options;
        }
        public Laptop this[string name] => throw new NotImplementedException();

        public Task AddAsync(Laptop t)
        {
            throw new NotImplementedException();
        }

        public Task AddNewLaptopAsync(NewLaptopVM data)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLaptopAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Laptop>> GetAllAsync()
        {
            var laptops = await _appDbContext.Laptops.ToListAsync();
            return laptops;
        }

        public Task<IEnumerable<Laptop>> GetAllAsync(params Expression<Func<Laptop, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Laptop> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Laptop> GetLaptopByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Laptop entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateLaptopAsync(NewLaptopVM data)
        {
            throw new NotImplementedException();
        }
    }
}
