using eTickets.Models;
using System.Linq.Expressions;

namespace PXLPRO2023Shoppers24.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T t);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
    }
}
