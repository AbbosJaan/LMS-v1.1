namespace LMS.Service.Interfaces
{
     public interface IGenericCRUDService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> CreateAsync(T model);
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(int id, T model);
        Task<bool> DeleteAsync(int id);
    }
}
