using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace PizzapannPresentationLayer.ViewComponents.Default
{
    public class _PizzaGaleryPartial:ViewComponent
    {
        private readonly IProductImageService _productImageService;

        public _PizzaGaleryPartial(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productImageService.TGetList();
            return View(values);
        }
    }
}
