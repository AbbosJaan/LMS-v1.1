using LMS.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LMS.UI.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicService _topicService;
        public TopicsController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        public async Task<IActionResult> Calendar(int id)
        {
            var topics = await _topicService.GetAllAsync(id);
            return View(topics);
        }
    }
}
