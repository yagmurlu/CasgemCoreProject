using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
