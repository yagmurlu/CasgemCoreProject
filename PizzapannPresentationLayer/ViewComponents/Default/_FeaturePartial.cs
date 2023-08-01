using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using System.Linq;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.title = c.Features.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = c.Features.Select(x => x.Description).FirstOrDefault();
            return View();
        }
    }
}
