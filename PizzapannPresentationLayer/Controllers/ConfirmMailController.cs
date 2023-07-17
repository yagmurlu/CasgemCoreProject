using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using PizzapannPresentationLayer.Models;
using System.Threading.Tasks;

namespace PizzapannPresentationLayer.Controllers
{
    public class ConfirmMailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ConfirmMailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.username = TempData["Username"];
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Index(ConfirmMailViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user.ConfirmCode.ToString()==model.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
