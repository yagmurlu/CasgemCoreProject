﻿using Microsoft.AspNetCore.Mvc;
using Pizzapan.BusinessLayer.Abstract;
using System;

namespace PizzapannPresentationLayer.Controllers
{
    public class DiscounController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscounController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public IActionResult CreateCode()
        {
            string[] symbols = { "A", "B", "C", "D", "E", "F", "G", "H" };
            int c1, c2, c3, c4;
            Random random= new Random();
            c1= random.Next(0,symbols.Length);
            c2= random.Next(0,symbols.Length);
            c3= random.Next(0,symbols.Length);
            c4= random.Next(0,symbols.Length);
            int c5= random.Next(10,100);
            ViewBag.v = symbols[c1] + symbols[c2] + symbols[c3] + symbols[c4] + c5;

            return View();
        }
       
        //public IActionResult CreateCode()
        //{
        //    return View();
        //}
    }
}
