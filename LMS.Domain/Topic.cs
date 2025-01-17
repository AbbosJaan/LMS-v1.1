﻿using LMS.Domain.Base;

namespace LMS.Domain
{
    public class Topic : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        
        //Reletionship
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
