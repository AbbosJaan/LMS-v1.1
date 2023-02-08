using LMS.Domain;
using LMS.Domain.Enums;

namespace LMS.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public decimal Gpa { get; set; }

        //Reletionships
        //public int GroupId { get; set; }
        //public virtual GroupViewModel Group { get; set; }

        public static explicit operator UserViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FullName = user.FullName,
                Gpa = user.Gpa,
                Role = user.Role,
                Password = user.Password
            };
        }
    }
}
