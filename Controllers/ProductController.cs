using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        public string Index()
        {
            return "product/index";
        }

        public string List()
        {
            return "product/list";
        }

        public string Details(int id)
        {
            return "product/details/"+id;
        }
    }
}
