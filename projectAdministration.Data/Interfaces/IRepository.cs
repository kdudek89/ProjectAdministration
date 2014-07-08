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

        //Rewrite in the future Find to a paging method 
        //depends on the structure of the application
        //Make a custom generic paging method
    }
}
