using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

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
        
    }
}
