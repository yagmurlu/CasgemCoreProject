using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.About
{
    public class _BestPizzaPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
