using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projectAdministration.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
         private Context db = null;
         private DbSet<T> table = null;
 
    public GenericRepository()
    {
        this.db = new Context();
        table = db.Set<T>();
    }
 
    public GenericRepository(Context db)
    {
        this.db = db;
        table = db.Set<T>();
    }
 
    public IEnumerable<T> SelectAll()
    {
        return table.ToList();
    }
 
    public T SelectByID(object id)
    {
        return table.Find(id);
    }
 
    public void Insert(T obj)
    {
        table.Add(obj);
    }
 
    public void Update(T obj)
    {
        table.Attach(obj);
        db.Entry(obj).State = EntityState.Modified;
    }
 
    public void Delete(object id)
    {
        T existing = table.Find(id);
        table.Remove(existing);
    }
 
    public void Save()
    {
        db.SaveChanges();
    }
}
}
