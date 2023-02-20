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
            if (!ModelState.IsValid)
            {
                return View(course);
            }
            await _courseService.CreateAsync(course);
           return Redirect(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var course = await _courseService.GetByIdForCreation(id);
            if(course == null) return View("NotFound");
            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Name,StartDate,EndDate")] CourseCreationViewModel course)
        {
            if(!ModelState.IsValid) return View(course);
            
            await _courseService.UpdateAsync(id, course);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            if (course == null) return View("NotFound");
            return View(course);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var courseDetails = await _courseService.GetByIdAsync(id);
            if( courseDetails == null) return View("NotFound");
            await _courseService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
