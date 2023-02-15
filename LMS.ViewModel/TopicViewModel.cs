
using LMS.Domain;

namespace LMS.ViewModel
{
    public class TopicViewModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        //Reletionship
        public CourseViewModel Course { get; set; }
        
        public static explicit operator TopicViewModel(Topic topic)
        {
            return new TopicViewModel
            {
                Name = topic.Name,
                //Course = (CourseViewModel)topic.Course,
                Date = topic.Date
            };
        }
    }
}
