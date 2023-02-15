using LMS.Service.Interfaces;
using LMS.ViewModel.CreationViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: api/<CoursesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses =  await _courseService.GetAllAsync();
            return Ok(courses);
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            if(course == null)
                return BadRequest("Course is not found!");
            return Ok(course);
        }

        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CourseCreationViewModel value)
        {
            var createdDate = await _courseService.CreateAsync(value);
            if (createdDate == null)
                return BadRequest("Course creation faild!");
            return Ok(createdDate);
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CourseCreationViewModel value)
        {
            var updatedDate = await _courseService.UpdateAsync(id, value);
            if (updatedDate == null)
                return BadRequest("Course update is faild!");
            return Ok(updatedDate);
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _courseService.DeleteAsync(id));
        }
    }
}
