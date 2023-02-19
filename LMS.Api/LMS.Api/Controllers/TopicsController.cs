using LMS.Service.Interfaces;
using LMS.ViewModel.CreationViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicsController : ControllerBase
    {
        private readonly ITopicService _topicService;
        public TopicsController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        // GET: api/<TopicsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _topicService.GetAllAsync());
        }

        // GET api/<TopicsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _topicService.GetByIdAsync(id);
            if(result == null)
                return NotFound("Topic is not found!");
            return Ok(result);
        }

        // POST api/<TopicsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TopicCreationViewModel model)
        {
            var createTopic = await _topicService.CreateAsync(model);
            if (createTopic == null)
                return BadRequest("Topic creation failed!");
            return Ok(createTopic);
        }

        // PUT api/<TopicsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TopicCreationViewModel model)
        {
            return Ok();
        }

        // DELETE api/<TopicsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) => Ok(await _topicService.DeleteAsync(id));
    }
}
