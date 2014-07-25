using projectAdministration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAdministration.Data.Interfaces
{
    interface ISkill : IRepository<RepositorySkill>
    {
        void SuperSkill();
    }
}
