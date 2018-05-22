using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.RepositoryImplementation;

namespace DataAccess.IRepository
{
    public interface IUnitOfWork<T> where T : class
    {
        BaseReposotory<T> UnitOfWork { get;}
        void Commit();
    }
}
