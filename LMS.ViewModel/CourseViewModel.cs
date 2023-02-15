

using LMS.Domain;

namespace LMS.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<TopicViewModel> Topics { get; set; }


        public static explicit operator CourseViewModel(Course entity)
        {
            var topics = new List<TopicViewModel>();
            if(entity.Topics != null)
            {
                foreach (var topic in entity.Topics)
                {
                    topics.Add((TopicViewModel)topic);
                }    
            }
            return new CourseViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Topics = topics
            };
        }
    }
}
