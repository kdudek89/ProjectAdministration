using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectAdministration.Domain;

namespace projectAdministration.Data
{
   public interface IUserRepository  : IDisposable
    { 
        IEnumerable<User> GetUsers();
        User GetUserByID(int UserId);
        void InsertUser(User user);
        void DeleteUser(int UserId);
        void UpdateUser(User user);
        void Save();
    }
}
