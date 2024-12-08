using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
