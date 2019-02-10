﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using kloud.Models;
using kloud.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace kloud.Controllers
{
    public class HomeController : Controller
    {
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly IDemoHelper _h;
		private readonly ProductsContext _pc;
		
		public HomeController(UserManager<IdentityUser> um, RoleManager<IdentityRole> rm, IDemoHelper helper, ProductsContext productsContext)
		{
			_userManager = um;
			_roleManager = rm;
			_h = helper;
			_pc = productsContext;
		}
		
        [AllowAnonymous]
		public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
		public IActionResult Shop()
        {
			ViewData["MainClass"] = "amado_product_area section-padding-100 clearfix";
            return View();
        }

        [AllowAnonymous]
		public IActionResult Cart()
        {
			ViewData["MainClass"] = "cart-table-area section-padding-100";
            return View();
        }

        [AllowAnonymous]
		public IActionResult Checkout()
        {
			ViewData["MainClass"] = "cart-table-area section-padding-100";
            return View();
        }

        [AllowAnonymous]
		public IActionResult ProductDetails()
        {
			ViewData["MainClass"] = "single-product-area section-padding-100 clearfix";
            return View();
        }

        public IActionResult Privacy()
        {
			//ViewData["MainClass"] = "products-catagories-area";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
			ViewData["MainClass"] = "products-catagories-area";
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}