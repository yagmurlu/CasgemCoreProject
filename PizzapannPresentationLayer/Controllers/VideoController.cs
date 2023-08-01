using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace PizzapannPresentationLayer.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        public IActionResult Index()
        {
            var value=_videoService.TGetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult EditVideo(int id)
        {
            var values = _videoService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditVideo(Video video)
        {
            _videoService.TUpdate(video);
            return RedirectToAction("Index");
        }
    }
}
