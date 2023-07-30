using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminIndex()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Feature()
        {
            return View();
        }
    }
}
