using StoreProject.Dal.Abstract;
using StoreProject.Dal.Context;
using StoreProject.Dal.Repositories;
using StoreProject.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject.Dal.Concrete
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
            
        }
    }
}
