using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUI.Models; //import
using ShopApp.WebUI.ViewModels;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product { Name = "Iphone X", Price = 6000, Description = "Iphone" };

            //ViewData["Category"] = "Phones";
            //ViewData["Product"] = product;

            ViewBag.Category = "Phones";
            //ViewBag.Product = product;

            return View(product);
        }

        public IActionResult List()
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

        public IActionResult Details(int id)
        {
            var p1 = new Product();

            p1.Name = "Samsung S6";
            p1.Price = 3000;
            p1.Description = "Smartphone";

            return View(p1);
        }
    }
}
