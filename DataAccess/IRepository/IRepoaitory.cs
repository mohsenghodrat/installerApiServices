using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    interface IRepoaitory<T> : IDisposable where T : class
    {
        IQueryable<T> GetQuery();
        void Add(T entity);
        void Add(IEnumerable<T> entities);
        void Delete(T entity);
        void Update(T originalEntity, T updateEntity);
        void SaveChanges();
    }
}
