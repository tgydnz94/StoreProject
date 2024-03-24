using StoreProject.Dal.Repositories.Interfaces;
using StoreProject.Entities.Models;
using StoreProject.Entities.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Dal.Abstract
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        IQueryable<Product> GetAllProductsWithDetails(ProductRequestParameters p);
        IQueryable<Product> GetShowcaseProducts(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        void CreateOneProduct(Product product);
        void DeleteOneProduct(Product product);
        void UpdateOneProduct(Product entity);
    }
}
