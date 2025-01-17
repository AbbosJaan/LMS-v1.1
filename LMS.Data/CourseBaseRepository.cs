﻿using LMS.Data.Interfaces;
using LMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class CourseBaseRepository : EntityBaseRepository<Course>, ICourseBaseRepository
    {
        private readonly AppDbContext _context;
        public CourseBaseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetAllCourseAsync() => await _context.Courses.Include(x => x.Topics).ToListAsync();

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await _context.Courses.Include(x => x.Topics).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Course> UpdateCourseAsync(int id, Course course)
        {
            var courseData = await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
            if(courseData != null)
            {
                courseData.StartDate = course.StartDate;
                courseData.EndDate = course.EndDate;
                courseData.Name = course.Name;
                await _context.SaveChangesAsync();
            }
            return courseData;
        }
    }
}
