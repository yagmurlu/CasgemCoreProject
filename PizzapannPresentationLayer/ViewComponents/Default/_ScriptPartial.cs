using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _ScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
