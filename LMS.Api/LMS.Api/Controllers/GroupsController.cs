using LMS.Service;
using LMS.Service.Interfaces;
using LMS.ViewModel;
using LMS.ViewModel.CreationViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupSerivce _service;
        public GroupsController(IGroupSerivce service)
        {
            _service = service;
        }


        //GET: api/Groups/
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        //GET: api/Groups/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null)
                return BadRequest("Group not found!");
            return Ok(result);
        }
        //POST: api/Groups/
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GroupCreationViewModel groupCreationViewModel)
        {
            var result = await _service.CreateAsync(groupCreationViewModel);
            if (result == null)
                return BadRequest("Group creadetional fail!");
            return Ok(result);
        }

        //PUT: api/put/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]GroupCreationViewModel groupCreationViewModel)
        {
            var updateGroup = await _service.UpdateAsync(id, groupCreationViewModel);
            return Ok(updateGroup);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if(result)
                return Ok(result);
            return BadRequest();
        }
    }
}
