using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Abstract
{
   public interface IUnitOfWork : IDisposable
    {
        IAdvertisementRepository Advertisements { get; }
        ICategoryRepository Categories { get; }

        int SaveChanges();
    }
}
