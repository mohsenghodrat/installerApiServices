using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.RepositoryImplementation;
namespace Business
{
    public class BaseBUsiness<T> where T : class
    {
        BaseUnitOfWork<T> baseUnitOfWork = null;
        public BaseBUsiness()
        {
            if(baseUnitOfWork == null)
            {
                baseUnitOfWork = new BaseUnitOfWork<T>();
            }
        }
        public void Add(T entity)
        {
            baseUnitOfWork.UnitOfWork.Add(entity);
        }
        public void Add(IEnumerable<T> entities)
        {
            baseUnitOfWork.UnitOfWork.Add(entities);
        }
        public void Delete(T entity)
        {
            baseUnitOfWork.UnitOfWork.Delete(entity);
        }
        public void Update(T originalEntity, T updateEntity)
        {
            baseUnitOfWork.UnitOfWork.Update(originalEntity, updateEntity);
        }
        public IQueryable<T> GetQuery()
        {
            return baseUnitOfWork.UnitOfWork.GetQuery();
        }
        public void Save()
        {
            baseUnitOfWork.Commit();
        }

    }
}
