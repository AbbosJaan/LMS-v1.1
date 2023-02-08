using LMS.Domain.Base;

namespace LMS.Domain
{
    public class Group : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Reletionships
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Groups_Courses> Groups_Courses { get; set; }
    }
}
