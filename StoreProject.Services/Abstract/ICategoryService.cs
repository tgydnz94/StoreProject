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
        IQueryable<Category> GetAllCategories(bool trackChanges);
    }
}
