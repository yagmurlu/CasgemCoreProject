using Microsoft.AspNetCore.Mvc;
using Pizzapan.DataAccessLayer.Concrete;
using System.Linq;

namespace PizzapannPresentationLayer.ViewComponents.About
{
    public class _VideoPartial:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.title = c.Videos.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = c.Videos.Select(x => x.Description).FirstOrDefault();
            ViewBag.url = c.Videos.Select(x => x.VideoUrl).FirstOrDefault();
            return View();
        }
    }
}
