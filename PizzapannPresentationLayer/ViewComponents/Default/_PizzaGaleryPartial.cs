using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _PizzaGaleryPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
