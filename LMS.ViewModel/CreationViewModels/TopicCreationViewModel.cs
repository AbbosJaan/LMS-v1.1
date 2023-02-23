using LMS.Domain;

namespace LMS.ViewModel.CreationViewModels
{
    public class TopicCreationViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public static explicit operator Topic(TopicCreationViewModel topic)
        {
            return new Topic
            {
                Name = topic.Name,
                Date = topic.Date,
            };
        }
    }
}
