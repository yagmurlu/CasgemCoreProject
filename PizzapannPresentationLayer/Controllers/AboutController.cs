using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
