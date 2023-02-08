

namespace LMS.ViewModel
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Reletionships
        public virtual ICollection<Groups_CoursesViewModel> Groups_Courses { get; set; }
        public virtual ICollection<TopicViewModel> Topics { get; set; }

    }
}
