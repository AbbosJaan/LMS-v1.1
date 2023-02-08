
namespace LMS.ViewModel
{
    public class TopicVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        //Reletionship
        public int CourseId { get; set; }
        public CourseVM Course { get; set; }
    }
}
