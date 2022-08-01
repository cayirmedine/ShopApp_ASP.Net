using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category { Name="Phones", Description="Phone Category" },
                new Category { Name="Computer", Description="Computer Category" },
                new Category { Name="Electronic", Description="Electronic Category" }
            };

            return View(categories);
        }
    }
}
