using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { ProductId=1, Name="Iphone 8", Price=3000, Description="Iphone", isApproved=true, ImageUrl="1.jpg" },
                new Product { ProductId=2, Name="Iphone X", Price=6000, Description="Iphone", isApproved=true, ImageUrl="2.jpg" },
                new Product { ProductId=3, Name="Iphone 11", Price=9000, Description="Iphone", ImageUrl="3.jpg" },
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}