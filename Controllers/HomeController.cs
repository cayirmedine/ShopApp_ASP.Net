using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUI.Models;
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product { Name="Iphone 8", Price=3000, Description="Iphone", isApproved=true },
                new Product { Name="Iphone X", Price=6000, Description="Iphone", isApproved=true },
                new Product { Name="Iphone 11", Price=9000, Description="Iphone" }
            };

            //ViewBag.Category = "Phones";

            var category = new Category { Name = "Phones", Description = "Phone Category" };
            //ViewBag.Category = category;

            var categories = new List<Category>()
            {
                new Category { Name="Phones", Description="Phone Category" },
                new Category { Name="Computer", Description="Computer Category" },
                new Category { Name="Electronic", Description="Electronic Category" }
            };

            var productViewModel = new ProductViewModel()
            {
                Categories = categories,
                Products = products
            };

            //return View(products);

            return View(productViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("TestView");
        }
    }
}
