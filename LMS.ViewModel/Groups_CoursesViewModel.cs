using LMS.Domain;

namespace LMS.ViewModel
{
    public class Groups_CoursesViewModel
    {
        public int GroupId { get; set; }
        public GroupViewModel Group { get; set; }

        public int CourseId { get; set; }
        public CourseViewModel Course { get; set; }

        public static explicit operator Groups_CoursesViewModel(Groups_Courses groups_Courses)
        {
            return new Groups_CoursesViewModel
            {
                GroupId = groups_Courses.GroupId,
                CourseId = groups_Courses.CourseId,
            };
        }
    }
}
