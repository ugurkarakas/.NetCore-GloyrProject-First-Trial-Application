using gloyr5gen.Entity;
using gloyr5gen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Abstract
{
   public interface ICategoryRepository:IGenericRepository<Category>
    {
        Category GetByName(string name);
        List<Category> GetTop5Category();
        IEnumerable<CategoryModel> GetAllWithAdvertisementCount();
    }
}
