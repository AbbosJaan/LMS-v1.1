namespace LMS.Domain
{
    public class Groups_Courses
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
