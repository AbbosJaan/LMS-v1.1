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

        public async Task<TopicViewModel> CreateAsync(TopicCreationViewModel topicCreationViewModel, int id)
        {
            var topic = (Topic)topicCreationViewModel;
            topic.CourseId = id;
            var result = await _topicBaseRepository.CreateTopicAsync(topic);
            return (TopicViewModel) result;

        }

        public async Task<bool> DeleteAsync(int id) => await _topicBaseRepository.DeleteAsync(id);

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TopicViewModel>> GetAllAsync(int courseId)
        {
            var topics = await _topicBaseRepository.GetAllTopicsAsync(courseId);
            var result = new List<TopicViewModel>();
            foreach (Topic topic in topics)
                result.Add((TopicViewModel)topic);
            return result;
        }

        public Task<TopicViewModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int id, TopicCreationViewModel model) => await _topicBaseRepository.UpdateTopicAsync(id, (Topic)model);

    }
}
