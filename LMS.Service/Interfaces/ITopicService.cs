using LMS.ViewModel;
using LMS.ViewModel.CreationViewModels;

namespace LMS.Service.Interfaces
{
    public interface ITopicService
    {
        Task<IEnumerable<TopicViewModel>> GetAllAsync(int id);
    }
}
