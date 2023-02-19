using LMS.Data.Interfaces;
using LMS.Domain;
using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModels;

namespace LMS.Service.Topics
{
    public class TopicService : ITopicService
    {
        private readonly ITopicBaseRepository _topicBaseRepository;
        public TopicService(ITopicBaseRepository topicBaseRepository)
        {
            _topicBaseRepository = topicBaseRepository;
        }

        public async Task<TopicViewModel> CreateAsync(TopicCreationViewModel model)
        {
            var updateTopic = await _topicBaseRepository.AddAsync((Topic) model, x => x.Course);
            return (TopicViewModel) updateTopic;
        }

        public async Task<bool> DeleteAsync(int id) => await _topicBaseRepository.DeleteAsync(id);

        public async Task<IEnumerable<TopicViewModel>> GetAllAsync()
        {
            var topics = await _topicBaseRepository.GetAllTopicsAsync();
            var result = new List<TopicViewModel>();
            foreach (Topic topic in topics)
                result.Add((TopicViewModel)topic);
            return result;
        } 

        public async Task<TopicViewModel> GetByIdAsync(int id)
        {
            var topic = await _topicBaseRepository.GetTopicByIdAsync(id);
            return (TopicViewModel) topic;
        }

        public Task<TopicCreationViewModel> GetByIdForCreation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int id, TopicCreationViewModel model) => await _topicBaseRepository.UpdateTopicAsync(id, (Topic)model);
    }
}
