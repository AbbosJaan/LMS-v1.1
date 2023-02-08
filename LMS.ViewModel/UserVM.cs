using LMS.Domain.Enums;

namespace LMS.ViewModel
{
    public class UserVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public decimal Gpa { get; set; }

        //Reletionships
        public int GroupId { get; set; }
        public virtual GroupVM Group { get; set; }
    }
}
