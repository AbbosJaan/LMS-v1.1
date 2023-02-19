using LMS.Data.Interfaces;

namespace LMS.Service.Interfaces
{
     public interface IGenericCRUDService<T, TCreation>  where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(TCreation model);
        Task<T> GetByIdAsync(int id);
        Task<TCreation> GetByIdForCreation(int id);
        Task UpdateAsync(int id, TCreation model);
        Task<bool> DeleteAsync(int id);

    }
}
