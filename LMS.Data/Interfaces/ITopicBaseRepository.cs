using LMS.Domain;
using System.Collections.Generic;

namespace LMS.Data.Interfaces
{
    public interface ITopicBaseRepository : IEntityBaseRepository<Topic>
    {
        Task<IEnumerable<Topic>> GetAllTopicsAsync();
        Task<Topic> GetTopicByIdAsync(int id);
        Task<Topic> UpdateTopicAsync(int id, Topic topic);
    }
}
