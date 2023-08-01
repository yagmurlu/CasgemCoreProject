using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace PizzapannPresentationLayer.Controllers
{
    public class BestPizzaController : Controller
    {
        private readonly IBestPizzaService _bestPizzaService;

        public BestPizzaController(IBestPizzaService bestPizzaService)
        {
            _bestPizzaService = bestPizzaService;
        }
        [HttpGet]
        public IActionResult BestPizza()
        {
            var values = _bestPizzaService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditBestPizza(int id)
        {
            var values = _bestPizzaService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditBestPizza(BestPizza bestPizza)
        {
            _bestPizzaService.TUpdate(bestPizza);
            return RedirectToAction("BestPizza");
        }
    }
}
