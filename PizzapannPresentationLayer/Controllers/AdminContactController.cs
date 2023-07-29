using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;

namespace PizzapannPresentationLayer.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
        public IActionResult DeleteContact(int id)
        {
            var value=_contactService.TGetById(id);
            _contactService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult GetMessageByThanks()
        {
            var values = _contactService.GetContactBySubjectWithThanks();
            return View(values);
        }
    }
}
