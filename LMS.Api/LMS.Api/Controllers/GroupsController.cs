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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(GroupCreationViewModel groupCreationViewModel)
        {
            var result = await _service.CreateAsync(groupCreationViewModel);
            if (result == null)
                return BadRequest("Group creadetional fail!");
            return Ok(result);
        }
    }
}
