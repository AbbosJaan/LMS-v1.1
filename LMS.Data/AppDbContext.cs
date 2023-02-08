using LMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions) 
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Groups_Courses> Groups_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups_Courses>().HasKey(am => new
            {
                am.CourseId,
                am.GroupId
            });

            modelBuilder.Entity<Groups_Courses>()
                .HasOne(m => m.Course)
                .WithMany(m => m.Groups_Courses)
                .HasForeignKey(m => m.CourseId);

            modelBuilder.Entity<Groups_Courses>()
                .HasOne(m => m.Group)
                .WithMany(m => m.Groups_Courses)
                .HasForeignKey(m => m.GroupId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
