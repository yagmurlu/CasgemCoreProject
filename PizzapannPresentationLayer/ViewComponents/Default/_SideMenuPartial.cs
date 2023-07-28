using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _SideMenuPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
