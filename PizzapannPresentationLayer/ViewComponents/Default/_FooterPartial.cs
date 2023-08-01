using Microsoft.AspNetCore.Mvc;
using Pizzapan.DataAccessLayer.Concrete;
using System.Linq;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.address = c.Footers.Select(x => x.Address).FirstOrDefault();
            ViewBag.mail = c.Footers.Select(x => x.Email).FirstOrDefault();
            ViewBag.openhourse = c.Footers.Select(x => x.OpenHourse).FirstOrDefault();
            ViewBag.openday = c.Footers.Select(x => x.OpenDay).FirstOrDefault();
            ViewBag.phone = c.Footers.Select(x => x.Phone).FirstOrDefault();
            return View();
        }
    }
}
