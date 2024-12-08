using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1500 },
            new Product { Id = 2, Name = "Mouse", Price = 25 },
            new Product { Id = 3, Name = "Keyboard", Price = 50 }
        };

        public List<Product> GetProducts() => products;

        public Product GetById(int id) => products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product) => products.Add(product);

        public void Update(Product product)
        {
            var existing = products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                existing.Name = product.Name;
                existing.Price = product.Price;
            }
        }

        public void Delete(int id) => products.RemoveAll(p => p.Id == id);
    }
}