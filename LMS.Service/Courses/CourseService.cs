using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;

namespace LMS.Service.Courses
{
    public class CourseService : ICourseService
    {
        public Task<CourseViewModel> CreateAsync(CourseCreationViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CourseViewModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CourseViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseViewModel> UpdateAsync(int id, CourseCreationViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
