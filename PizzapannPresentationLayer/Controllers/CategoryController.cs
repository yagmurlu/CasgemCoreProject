using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace PizzapannPresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values=_categoryService.TGetList();

            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            _categoryService.TInsert(p);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var value=_categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var value= _categoryService.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
