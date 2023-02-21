using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;

namespace LMS.Service.Interfaces
{
    public  interface ICourseService : IGenericCRUDService<CourseViewModel, CourseCreationViewModel>
    {
        Task<List<TopicViewModel>> GetCourseTopicsAsync(int id);
    }
}
