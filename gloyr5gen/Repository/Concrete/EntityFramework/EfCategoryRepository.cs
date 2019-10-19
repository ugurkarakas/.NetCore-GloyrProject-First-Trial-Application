using gloyr5gen.Entity;
using gloyr5gen.Models;
using gloyr5gen.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(GloyrContext context):base(context)
        {

        }
        public GloyrContext GloyrContext
        {
            get { return context as GloyrContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithAdvertisementCount()
        {
            return GelAll().Select(i => new CategoryModel()
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Categoryaciklama = i.Categoryaciklama,
                Image = i.Image,
                Count = i.AdvertisementCategories.Count()
            });
        }

        public Category GetByName(string name)
        {
            return GloyrContext.Categories.Where(i => i.CategoryName==name).FirstOrDefault();
        }

        public List<Category> GetTop5Category()
        {
            return GloyrContext.Categories.OrderByDescending(i => i.CategoryId).Take(5).ToList();

        }
    }
}
