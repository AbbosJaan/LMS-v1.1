

namespace LMS.ViewModel
{
    public class GroupVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Reletionships
        public virtual ICollection<UserVM> Users { get; set; }
        public virtual ICollection<Groups_Courses> Groups_Courses { get; set; }
    }
}
