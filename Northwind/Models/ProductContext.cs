using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.Models
{
    public class ProductContext
    {
        private List<Product> products;

        public ProductContext()
        {
            products = new List<Product>()
            {
                new Product() {Id = 100, Name = "500GB HDD", Price = 49.99},
                new Product() {Id = 101, Name = "250 SSD", Price = 99.99},
                new Product() {Id = 102, Name = "4GB Ram", Price = 39.99},
                new Product() {Id = 103, Name = "Mouse", Price = 15.99},
                new Product() {Id = 104, Name = "Gaming Mouse", Price = 75.99},
                new Product() {Id = 105, Name = "Keyboard", Price = 24.99}
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product Find(int Id)
        {
            return products.Where(p => p.Id == Id).SingleOrDefault();
        }
    }
}