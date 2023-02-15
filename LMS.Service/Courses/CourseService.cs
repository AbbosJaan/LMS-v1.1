using LMS.Data.Interfaces;
using LMS.Domain;
using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;

namespace LMS.Service.Courses
{
    public class CourseService : ICourseService
    {
        private readonly ICourseBaseRepository _repository;
        public CourseService(ICourseBaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<CourseViewModel> CreateAsync(CourseCreationViewModel model)
        {
            var result = await _repository.AddAsync((Course)model);
            return (CourseViewModel)result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<CourseViewModel>> GetAllAsync()
        {
            var courses = await _repository.GetAllAsync();
            IEnumerable<CourseViewModel> viewCourses = new  List<CourseViewModel>();
            foreach(var course in courses)
            {
                await _repository.AddAsync(course);
            }
            return viewCourses;
        }

        public async Task<CourseViewModel> GetByIdAsync(int id)
        {
            return (CourseViewModel)await _repository.GetByIdAsync(id);
        }

        public async Task<CourseViewModel> UpdateAsync(int id, CourseCreationViewModel model)
        {
            var course =  await _repository.UpdateAsync(id, (Course)model);
            return (CourseViewModel)course;
        }

    }
}
