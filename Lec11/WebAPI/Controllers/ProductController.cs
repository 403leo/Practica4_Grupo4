using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{    
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;        

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetProducts();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var producto = _productService.GetById(id);
            if(producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public IHttpActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _productService.CreateProduct(product);
            return Ok(product);
        }

        [HttpPut]
        public IHttpActionResult Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _productService.UpdateProduct(product);
            return Ok(product);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

    }
}
