using Microsoft.AspNetCore.Identity;

namespace LMS.Domain
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        //Reletionships
        public int? GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
