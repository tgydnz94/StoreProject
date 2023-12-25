using StoreProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Services.Abstract
{
    public interface ICategoryService
    {
        public void CreateCategory(Category category);
        IQueryable<Category> GetAllCategories(bool trackChanges);
    }
}
