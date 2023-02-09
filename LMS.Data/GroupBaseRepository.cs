using LMS.Data.Interfaces;
using LMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class GroupBaseRepository : EntityBaseRepository<Group>, IGroupBaseRepository
    {
        private readonly AppDbContext _context;
        public GroupBaseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Group>> GetAllWithCourseAsync()
        {
            var groups = await _context.Groups
                .Include(u => u.Users)
                .Include(gc => gc.Groups_Courses)
                .ThenInclude(c => c.Course)
                .ToListAsync();

            return groups;
        }
    }
}
