

namespace LMS.ViewModel
{
    public class CourseVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Reletionships
        public virtual ICollection<Groups_Courses> Groups_Courses { get; set; }
        public virtual ICollection<TopicVM> Topics { get; set; }

    }
}
