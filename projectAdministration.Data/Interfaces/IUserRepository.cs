using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectAdministration.Domain;
using projectAdministration.Data.Interfaces;

namespace projectAdministration.Data
{
   public interface IUserRepository  : IRepository<User>
    { 
       //@Darek tutaj możesz dodać cutomowe metody
       //Wystarczy ten interfejs dać do klasy RepositoryUser
        IEnumerable<User> GetUsers();
    }
}
