using projectAdministration.Data.Interfaces;
using projectAdministration.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAdministration.Data
{
    public class Repository<T> : IRepository<T> where T : class, IIdentifiable
    {
        private readonly Context context;
        public Repository(IUnitOfWork uow)
        {
            context = uow.Context as Context;
        }
        public IQueryable<T> All
        {
            get
            {
                return context.Set<T>();
            }
        }
        public T Find(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Insert(T item)
        {
            context.Entry(item).State = EntityState.Added;
        }
        public void Update(T item)
        {
            context.Set<T>().Attach(item);
            context.Entry(item).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var item = context.Set<T>().Find(id);
            context.Set<T>().Remove(item);
        }
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
