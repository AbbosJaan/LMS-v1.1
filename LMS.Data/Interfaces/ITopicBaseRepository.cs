using LMS.Domain;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LMS.Data.Interfaces
{
    public interface ITopicBaseRepository : IEntityBaseRepository<Topic>
    {
        Task<IEnumerable<Topic>> GetAllTopicsAsync(int courseId);
        Task<Topic> GetTopicByIdAsync(int id);
        Task<Topic> UpdateTopicAsync(int id, Topic topic);
        Task<Topic> CreateTopicAsync(Topic topic);
    }
}
