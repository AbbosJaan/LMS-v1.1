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
            var courses = await _repository.GetAllCourseAsync();
            List<CourseViewModel> viewCourses = new List<CourseViewModel>();
            foreach(var course in courses)
            {
                viewCourses.Add((CourseViewModel)course);
            }
            return viewCourses;
        }

        public async Task<CourseViewModel> GetByIdAsync(int id)
        {
            return (CourseViewModel)await _repository.GetCourseByIdAsync(id);
        }

        public async Task<CourseCreationViewModel> GetByIdForCreation(int id)
        {
            return (CourseCreationViewModel)await _repository.GetByIdAsync(id);
        }

        public async Task<List<TopicViewModel>> GetCourseTopicsAsync(int id)
        {
            var courseDetails = await _repository.GetCourseByIdAsync(id);
            var topicList = new List<TopicViewModel>();
            foreach (var item in courseDetails.Topics)
            {
                topicList.Add((TopicViewModel) item);
            }
            return topicList;
        }

        public async Task UpdateAsync(int id, CourseCreationViewModel model) => await _repository.UpdateCourseAsync(id, (Course)model);
    }
}
