
namespace LMS.ViewModel
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        //Reletionship
        public int CourseId { get; set; }
        public CourseViewModel Course { get; set; }
    }
}
