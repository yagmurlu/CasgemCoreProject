using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
