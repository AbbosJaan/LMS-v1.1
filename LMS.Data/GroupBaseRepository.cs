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
        public async Task<Group> UpdateGroupAsync(int id, Group entity)
        {
            var updatedGroup = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);
            updatedGroup.Name = entity.Name;
            await _context.SaveChangesAsync();
            return updatedGroup;
        }
    }
}
