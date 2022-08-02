using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUI.Models; //import
using ShopApp.WebUI.ViewModels;
using ShopApp.WebUI.Data;

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
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
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
