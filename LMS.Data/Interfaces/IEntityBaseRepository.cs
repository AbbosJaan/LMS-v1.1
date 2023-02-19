using LMS.Domain.Base;
using System.Linq.Expressions;

namespace LMS.Data.Interfaces
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<T> AddAsync(T entity, params Expression<Func<T, object>>[] includePrioerties);
        Task UpdateAsync(int id, T entity);
        Task<bool> DeleteAsync(int id);
    }
}
