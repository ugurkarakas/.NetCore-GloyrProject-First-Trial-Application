using gloyr5gen.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Abstract
{
    public interface IAdvertisementRepository : IGenericRepository<Advertisement>
    {
        List<Advertisement> GetTop5Products();
    }
}
