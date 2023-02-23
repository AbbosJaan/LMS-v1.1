
using LMS.Domain;

namespace LMS.ViewModel
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        //Reletionship
        public CourseViewModel Course { get; set; }
        
        public static explicit operator TopicViewModel(Topic topic)
        {
            if(topic == null)
                return null;
            var course = new CourseViewModel();
            if(topic.Course != null)
            {

                course.Name = topic.Course.Name;
                course.Id = topic.Course.Id;
                course.EndDate = topic.Course.EndDate;
                course.StartDate = topic.Course.StartDate;
                
            }
            return new TopicViewModel
            {
                Id = topic.Id,
                Name = topic.Name,
                Course = course,
                Date = topic.Date
            };
        }
    }
}
