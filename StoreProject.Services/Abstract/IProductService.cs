using StoreProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Services.Abstract
{
    public interface IProductService
    {
        public void AddProduct(Product product);
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product ? GetOneProduct(int id, bool trackChanges);
    }
}
