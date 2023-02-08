namespace LMS.ViewModel
{
    public class Groups_Courses
    {
        public int GroupId { get; set; }
        public GroupVM Group { get; set; }

        public int CourseId { get; set; }
        public CourseVM Course { get; set; }
    }
}
