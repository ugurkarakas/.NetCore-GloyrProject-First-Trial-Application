using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace gloyr5gen.Repository.Abstract
{
   public interface IGenericRepository<T>where T:class
    {
        T Get(int id);
        IQueryable<T> GelAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
