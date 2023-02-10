using LMS.Data.Interfaces;

namespace LMS.Service.Interfaces
{
     public interface IGenericCRUDService<T, T2>  where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T2 model);
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(int id, T2 model);
        Task<bool> DeleteAsync(int id);
    }
}
