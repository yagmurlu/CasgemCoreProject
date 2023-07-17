using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.Models
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
