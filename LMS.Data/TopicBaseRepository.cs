using LMS.Data.Interfaces;
using LMS.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LMS.Data
{
    public class TopicBaseRepository : EntityBaseRepository<Topic>, ITopicBaseRepository
    {
        private readonly AppDbContext _context;
        public TopicBaseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Topic>> GetAllTopicsAsync() => await _context.Topics.Include(x => x.Course).ToListAsync();
        public async Task<Topic> GetTopicByIdAsync(int id) => await _context.Topics.Include(x => x.Course).FirstOrDefaultAsync(x => x.Id == id);

        public async Task<Topic> UpdateTopicAsync(int id, Topic topic)
        {
            var updateTopic = await _context.Topics.FirstOrDefaultAsync(x => x.Id == id);
            if(updateTopic != null)
            {
                updateTopic.Name = topic.Name;
                updateTopic.Date = topic.Date;
                updateTopic.CourseId = topic.CourseId;
                await _context.SaveChangesAsync();
            }
            return updateTopic;
        }
    }
}
