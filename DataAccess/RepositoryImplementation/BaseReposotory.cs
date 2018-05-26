using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DataContext;
using DataAccess.IRepository;
namespace DataAccess.RepositoryImplementation
{
    public class BaseReposotory<T> : IRepoaitory<T> where T: class
    {
        private DbSet<T> db = null;
        private RadioInstallerContext context = null;

        public BaseReposotory()
        {
            if (context == null)
            {
                context = new RadioInstallerContext();
            }
            Database.SetInitializer<RadioInstallerContext>(null);
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;
            db = context.Set<T>();
        }

        public BaseReposotory(RadioInstallerContext context)
        {
            if (this.context == null)
            {
                this.context = context;
            }
            Database.SetInitializer<RadioInstallerContext>(null);
            context.Configuration.AutoDetectChangesEnabled = false;
            context.Configuration.ValidateOnSaveEnabled = false;
            db = context.Set<T>();
        }
        public virtual void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IQueryable<T> GetQuery()
        {
            return db;
        }

        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity is Empty For Adding");
            }
            context.Entry<T>(entity).State = EntityState.Added;
            db.Add(entity);
        }

        public void Add(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entities Are  Empty For Adding");
            }
            
            foreach (T entity in entities)
            {
                context.Entry<T>(entity).State = EntityState.Added;
                db.Add(entity);
            }
        }

        public void Delete(T entity)
        {
            if (entity ==  null)
            {
                throw new ArgumentNullException("Entity is Empty For Deleting");
            }
            context.Entry<T>(entity).State = EntityState.Deleted;
            db.Remove(entity);
        }

        public void Update(T originalEntity, T updateEntity)
        {
            if (originalEntity == null || updateEntity == null)
            {
                throw new ArgumentNullException("Entities Are Empty For Updating");
            }

            context.Entry(originalEntity).State = EntityState.Modified;
            context.Entry(originalEntity).CurrentValues.SetValues(updateEntity);
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
