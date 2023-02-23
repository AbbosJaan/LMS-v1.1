using LMS.ViewModel;
using LMS.ViewModel.CreationViewModels;

namespace LMS.Service.Interfaces
{
    public interface ITopicService
    {
        Task<IEnumerable<TopicViewModel>> GetAllAsync(int id);
        Task<TopicViewModel> GetByIdAsync(int id);
        Task<TopicViewModel> CreateAsync(TopicCreationViewModel topicCreationViewModel, int id);
        Task UpdateAsync(int id, TopicCreationViewModel topicCreationViewModel);
        Task<bool> DeleteByIdAsync(int id);
    }
}
