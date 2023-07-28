using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           
            return View();
        }
    }
}
