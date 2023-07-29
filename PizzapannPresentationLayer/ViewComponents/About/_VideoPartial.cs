using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.About
{
    public class _VideoPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
