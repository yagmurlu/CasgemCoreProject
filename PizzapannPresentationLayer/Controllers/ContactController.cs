﻿using Microsoft.AspNetCore.Mvc;

namespace PizzapannPresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
