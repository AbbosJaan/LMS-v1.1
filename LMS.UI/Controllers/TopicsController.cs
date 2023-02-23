using LMS.Service.Helpers;
using LMS.Service.Interfaces;
using LMS.ViewModel.CreationViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LMS.UI.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicService _topicService;
        private readonly ConvertIntToGetCourseIdForTopicCreation _convertForCreation;
        public TopicsController(ITopicService topicService, ConvertIntToGetCourseIdForTopicCreation convertForCreation)
        {
            _topicService = topicService;
            _convertForCreation = convertForCreation;
        }

        public async Task<IActionResult> Calendar(int id)
        {
            var topics = await _topicService.GetAllAsync(id);
            return View(topics);
        }
        public IActionResult Create(int id)
        {
            var converted = _convertForCreation.Convertor(id);
            return View(converted);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Date")] TopicCreationViewModel topic, int id)
        {
            if(!ModelState.IsValid)
            {
                return View(topic);
            }
            await _topicService.CreateAsync(topic, id);
            return RedirectToAction(nameof(Calendar));
        }
    }
}
