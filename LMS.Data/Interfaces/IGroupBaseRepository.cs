﻿using LMS.Domain;

namespace LMS.Data.Interfaces
{
    public interface IGroupBaseRepository : IEntityBaseRepository<Group>
    {
        Task<IEnumerable<Group>> GetAllGroupsAsync();
        Task<Group> UpdateGroupAsync(int id, Group group); 
    }
}
