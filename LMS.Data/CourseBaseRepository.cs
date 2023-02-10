using LMS.Data.Interfaces;
using LMS.Domain;

namespace LMS.Data
{
    public class CourseBaseRepository : EntityBaseRepository<Course>, ICourseBaseRepository
    {
        private readonly AppDbContext _context;
        public CourseBaseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
