using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using PizzapannPresentationLayer.Models;
using System;
using System.IO;

namespace PizzapannPresentationLayer.Controllers
{
    public class ProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public ProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            var resource=Directory.GetCurrentDirectory();
            var extension =Path.GetExtension(model.Image.Name);
            var imageName=Guid.NewGuid()+extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream=new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            ProductImage productImage=new ProductImage();
            productImage.ImageURL = imageName;
            _productImageService.TInsert(productImage);

            
            return RedirectToAction("ImageList");
        }
    }
}
