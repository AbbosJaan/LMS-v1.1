

using LMS.Domain;

namespace LMS.ViewModel.CreationViewModel
{
    public class CourseCreationViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static explicit operator Course(CourseCreationViewModel model)
        {
            return new Course
            {
                Name = model.Name,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
            };
        }
    }
}
