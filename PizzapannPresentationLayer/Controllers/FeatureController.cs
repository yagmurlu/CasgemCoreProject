using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace PizzapannPresentationLayer.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetFeature()
        {
            var value = _featureService.TGetList();
            return View(value);
        }
        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var value=_featureService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditFeature(Feature feature)
        {
             _featureService.TUpdate(feature);
            return RedirectToAction("GetFeature");
        }

    }
}
