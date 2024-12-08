using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void CreateProduct(Product product) => _productRepository.Add(product);

        public void DeleteProduct(int id) => _productRepository.Delete(id);

        public Product GetById(int id) => _productRepository.GetById(id);

        public List<Product> GetProducts() => _productRepository.GetProducts();

        public void UpdateProduct(Product product) => _productRepository.Update(product);
    }
}