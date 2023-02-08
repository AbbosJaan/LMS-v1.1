using LMS.Data;
using LMS.Domain;

namespace LMS.Api.Statics
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();


                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                           Email = "student1@gmail.com",
                           FullName = "John Due",
                           Gpa = 4,
                           GroupId = 1,
                           Password = "1234",
                           Role = Domain.Enums.UserRole.Student
                        },
                        new User()
                        {
                            Email = "student2@gmail.com",
                            FullName = "Karl",
                            Gpa = 3,
                            GroupId = 1,
                            Password = "1234",
                            Role = Domain.Enums.UserRole.Student
                        },
                        new User()
                        {
                            Email = "student3@gmail.com",
                            FullName = "Tom",
                            Gpa = 3,
                            GroupId = 2,
                            Password = "1234",
                            Role = Domain.Enums.UserRole.Student
                        },
                        new User()
                        {
                            Email = "student4@gmail.com",
                            FullName = "Alex",
                            Gpa = 5,
                            GroupId = 2,
                            Password = "1234",
                            Role = Domain.Enums.UserRole.Student
                        },
                        new User()
                        {
                            Email = "student5@gmail.com",
                            FullName = "Sherdar",
                            Gpa = 3,
                            GroupId = 3,
                            Password = "1234",
                            Role = Domain.Enums.UserRole.Student
                        }

                    });
                    context.SaveChanges();
                }

                //Courses
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            Name = "Discrete structures",
                            StartDate = new DateTime(2023, 12, 25),
                            EndDate = new DateTime(2024, 12, 25)
                        },
                        new Course()
                        {
                            Name = "Data structures and algorithms",
                            StartDate = new DateTime(2022, 09, 12),
                            EndDate = new DateTime(2023, 01, 10)
                        },
                        new Course()
                        {
                            Name = "Cybersecurity fundamentals",
                            StartDate = new DateTime(2022, 09, 12),
                            EndDate = new DateTime(2023, 01, 10)
                        }

                    });
                    context.SaveChanges();
                }

                //Topics
                if (!context.Topics.Any())
                {
                    context.Topics.AddRange(new List<Topic>()
                    {
                        new Topic()
                        {
                            Name = "Kirish. Diskret tuzilmalar. To‘plamlar. To‘plam elementlari.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlarning berilishi. Qism to‘plamlar. To‘plamlarning turlari. To‘plamlar ustida amallarning xossalari.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 1,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "Kirish. Diskret tuzilmalar. To‘plamlar. To‘plam elementlari.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlarning berilishi. Qism to‘plamlar. To‘plamlarning turlari. To‘plamlar ustida amallarning xossalari.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 2,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "Kirish. Diskret tuzilmalar. To‘plamlar. To‘plam elementlari.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlarning berilishi. Qism to‘plamlar. To‘plamlarning turlari. To‘plamlar ustida amallarning xossalari.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        },
                        new Topic()
                        {
                            Name = "To‘plamlar ustida amallar. To‘plamlarning birlashmasi. To‘plamlarning kesishmasi. To‘plamlarning ayirmasi.",
                            CourseId = 3,
                            Date = DateTime.Now,
                        }

                    });
                    context.SaveChanges();
                }

                // Groups
                if (!context.Groups.Any())
                {
                    context.Groups.AddRange(new List<Group>()
                    {
                        new Group()
                        {
                            Name = Guid.NewGuid().ToString().Substring(0,5),
                        },
                        new Group()
                        {
                            Name = Guid.NewGuid().ToString().Substring(0,5)
                        },
                        new Group()
                        {
                            Name = Guid.NewGuid().ToString().Substring(0,5)                        
                        }
                    });
                    context.SaveChanges();
                }


                //Groups & Courses
                if (!context.Groups_Courses.Any())
                {
                    context.Groups_Courses.AddRange(new List<Groups_Courses>()
                    {
                        new Groups_Courses()
                        {
                            GroupId = 1,
                            CourseId = 1,
                        },
                        new Groups_Courses()
                        {
                            GroupId = 1,
                            CourseId = 2,
                        },
                        new Groups_Courses()
                        {
                            GroupId = 2,
                            CourseId = 2,
                        },
                        new Groups_Courses()
                        {
                            GroupId = 2,
                            CourseId = 3,
                        },
                        new Groups_Courses()
                        {
                            GroupId = 3,
                            CourseId = 1,
                        },
                        new Groups_Courses()
                        {
                            GroupId = 3,
                            CourseId = 2,
                        },
                        new Groups_Courses()
                        {
                            GroupId = 3,
                            CourseId = 3,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }


    }
}
