﻿using LMS.Domain;

namespace LMS.Data.Interfaces
{
    public interface IGroupBaseRepository : IEntityBaseRepository<Group>
    {
        Task<IEnumerable<Group>> GetAllWithCourseAsync();
    }
}