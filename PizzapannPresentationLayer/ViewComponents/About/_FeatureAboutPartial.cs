using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.About
{
    public class _FeatureAboutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
