using projectAdministration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAdministration.Data.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> All { get; }
        T Find(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
