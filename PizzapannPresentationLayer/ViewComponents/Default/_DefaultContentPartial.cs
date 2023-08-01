using Microsoft.AspNetCore.Mvc;
using Pizzapan.DataAccessLayer.Concrete;
using System.Linq;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _DefaultContentPartial:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.title = c.BestPizzas.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = c.BestPizzas.Select(x => x.Description).FirstOrDefault();
            ViewBag.sub1 = c.BestPizzas.Select(x => x.Subtitle1).FirstOrDefault();
            ViewBag.sub2 = c.BestPizzas.Select(x => x.Subtitle2).FirstOrDefault();
            ViewBag.sub3 = c.BestPizzas.Select(x => x.Subtitle3).FirstOrDefault();
            ViewBag.sub4 = c.BestPizzas.Select(x => x.Subtitle4).FirstOrDefault();
            return View();
        }
    }
}
