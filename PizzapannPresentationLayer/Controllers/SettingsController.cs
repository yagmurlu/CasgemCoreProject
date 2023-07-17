using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Pizzapan.EntityLayer.Concrete;
using PizzapannPresentationLayer.Models;
using System.Threading.Tasks;

namespace PizzapannPresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Username = value.UserName;
            model.Name = value.Name;
            model.Surname = value.Surname;
            model.Email = value.Email;
            model.City = value.City;

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Name= model.Username;
            user.Surname= model.Surname;
            user.Email= model.Email;
            user.City= model.City;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            var result=await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View();
            }
        }
    }
}
