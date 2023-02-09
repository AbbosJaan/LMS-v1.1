

using LMS.Domain;

namespace LMS.ViewModel
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Reletionships
        public virtual ICollection<UserViewModel> Users { get; set; }
        public virtual ICollection<Groups_CoursesViewModel> Groups_Courses { get; set; }


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
            foreach (User user in entity.Users)
            {
                users.Add((UserViewModel)user);
            }

            ICollection<Groups_CoursesViewModel> groups_coures = new List<Groups_CoursesViewModel>();
            foreach (Groups_Courses item in entity.Groups_Courses)
            {
                groups_coures.Add((Groups_CoursesViewModel)item);
            }
            return new GroupViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                //Groups_Courses = groups_coures,
                Users = users
            };
        }
    }
}
