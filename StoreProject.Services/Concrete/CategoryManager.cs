using StoreProject.Dal.Abstract;
using StoreProject.Entities.Models;
using StoreProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IQueryable<Category> GetAllCategories(bool trackChanges)
        {
            return _categoryRepository.FindAll(trackChanges);
        }
    }
}
