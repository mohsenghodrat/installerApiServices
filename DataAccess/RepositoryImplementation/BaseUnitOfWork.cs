using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.IRepository;
using DataAccess.DataContext;
namespace DataAccess.RepositoryImplementation
{
    public class BaseUnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private RadioInstallerContext context = null;
        private BaseReposotory<T> baseRepo = null;
        public BaseUnitOfWork()
        {
            if (context == null)
            {
                context = new RadioInstallerContext();
            }
        }

        public BaseReposotory<T> UnitOfWork => (baseRepo ?? new BaseReposotory<T>(context));
        public void Commit()
        {
            UnitOfWork.SaveChanges();
        }
    }
}
