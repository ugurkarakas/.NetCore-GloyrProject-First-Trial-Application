using gloyr5gen.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly GloyrContext dbcontext;
        public EfUnitOfWork(GloyrContext _dbcontext)
        {
            dbcontext = _dbcontext ?? throw new ArgumentNullException("dbcontext can not be null");
        }

        private IAdvertisementRepository _advertisements;
        private ICategoryRepository _categories;
        public IAdvertisementRepository Advertisements
        {
            get
            {
                return _advertisements ?? (_advertisements = new EfAdvertisementRepository(dbcontext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbcontext));
            }
        }
        public int SaveChanges()
        {
            try
            {
              return dbcontext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void Dispose()
        {
            dbcontext.Dispose();
        }
    }
}
