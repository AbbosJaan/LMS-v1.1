

using LMS.Domain;

namespace LMS.ViewModel
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Reletionships
        public virtual ICollection<UserViewModel> Users { get; set; }
        public virtual ICollection<CourseViewModel> Courses { get; set; }


        //Operators - mapping
        public static explicit operator Group(GroupViewModel viewModel)
        {
            return new Group
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
            };
        }
        public static explicit operator GroupViewModel(Group entity)
        {
            ICollection<UserViewModel> users = new List<UserViewModel>();
            if(entity.Users != null)
            {
                foreach (User user in entity.Users)
                {
                    users.Add((UserViewModel)user);
                }
            }
            ICollection<CourseViewModel> courses = new List<CourseViewModel>();
            if(entity.Groups_Courses != null)
            {
                foreach (Groups_Courses item in entity.Groups_Courses)
                {
                    courses.Add((CourseViewModel)item.Course);
                }
            }
            return new GroupViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Courses = courses,
                Users = users
            };
        }
    }
}
