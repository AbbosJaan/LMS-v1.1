using LMS.Domain;

namespace LMS.Data.Interfaces
{
    public interface ICourseBaseRepository : IEntityBaseRepository<Course>
    {
        Task<Course> UpdateCourseAsync(int id, Course course);
        Task<List<Course>> GetAllCourseAsync();
        Task<Course> GetCourseByIdAsync(int id);
    }
}
