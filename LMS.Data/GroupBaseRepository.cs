using LMS.Data.Interfaces;
using LMS.Domain;

namespace LMS.Data
{
    public class GroupBaseRepository : EntityBaseRepository<Group>, IGroupBaseRepository
    {
        private readonly AppDbContext _context;
        public GroupBaseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
