using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _DefaultContentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
