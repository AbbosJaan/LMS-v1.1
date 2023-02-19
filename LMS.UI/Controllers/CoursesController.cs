using LMS.Service.Interfaces;
using LMS.ViewModel.CreationViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LMS.UI.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            return View(courses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,StartDate,EndDate")] CourseCreationViewModel course)
        {
            if(!ModelState.IsValid)
            {
                return View(course);
            }
            await _courseService.CreateAsync(course);
            return Redirect(nameof(Index));
        }
    }
}
