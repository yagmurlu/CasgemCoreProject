using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.About
{
    public class _TeamPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
