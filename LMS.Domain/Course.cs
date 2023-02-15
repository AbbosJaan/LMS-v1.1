using LMS.Domain.Base;

namespace LMS.Domain
{
    public class Course : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Reletionships
        public virtual ICollection<Groups_Courses> Groups_Courses { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
