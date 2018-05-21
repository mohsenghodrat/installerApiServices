using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepository;
namespace DataAccess.RepositoryImplementation
{
    public class Repository<T> : IRepoaitory<T> where T: class
    {
        public virtual void Dispose(bool Disposing)
        {

        }
        public void Dispose()
        {
            
        }

        public IQueryable<T> GetQuery()
        {
            throw new NotImplementedException();
        }

        public void Ad(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T originalEntity, T updateEntity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
