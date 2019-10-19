using gloyr5gen.Entity;
using gloyr5gen.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Concrete.EntityFramework
{
    public class EfAdvertisementRepository : EfGenericRepository<Advertisement>, IAdvertisementRepository
    {
        public EfAdvertisementRepository(GloyrContext context):base(context)
        {

        }
        public GloyrContext GloyrContext
        {
            get { return context as GloyrContext; }
        }

        public List<Advertisement> GetTop5Products()
        {
            return GloyrContext.Advertisements.OrderByDescending(i => i.AdvertisementId).Take(5).ToList();
        }
    }
}
