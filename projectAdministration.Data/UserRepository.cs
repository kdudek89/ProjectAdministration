using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectAdministration.Domain;
using System.Data.Entity;

namespace projectAdministration.Data
{
    public class UserRepository : IUserRepository, IDisposable
    {
         private Context context;

         public UserRepository(Context context)
        {
            this.context = context;
        }

         public UserRepository()
         {
             this.context = new Context();
         }

         public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

         public User GetUserByID(int id)
        {
            return context.Users.Find(id);
        }

         public void InsertUser(User user)
        {
            context.Users.Add(user);
        }

         public void DeleteUser(int userId)
        {
            User user = context.Users.Find(userId);
            context.Users.Remove(user);
        }

        public void UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
