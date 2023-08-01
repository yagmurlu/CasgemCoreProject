using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace PizzapannPresentationLayer.Controllers
{
    public class FooterController : Controller
    {
        private readonly IFooterService _footerService;

        public FooterController(IFooterService footerService)
        {
            _footerService = footerService;
        }

        public IActionResult GetFooter()
        {
            var values = _footerService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditFooter(int id)
        {
            var value = _footerService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditFooter(Footer footer)
        {
            _footerService.TUpdate(footer);
            return RedirectToAction("GetFooter");
        }
    }
}
