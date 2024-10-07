using Microsoft.AspNetCore.Mvc;
using Podcast.BLL.Services.Contracts;
using Podcast.BLL.ViewModels.TopicViewModels;

namespace Podcast.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AutoValidateAntiforgeryToken]
    public class TopicController : Controller
    {
        private readonly ITopicService _topicService;
        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _topicService.GetListAsync();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Create(TopicCreateViewModel vm)
        {
            var existTopic= _topicService.CreateAsync(vm);
            return RedirectToAction(nameof(Index));
        }
    }
}
