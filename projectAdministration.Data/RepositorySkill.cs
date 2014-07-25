using projectAdministration.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAdministration.Data
{
    class RepositorySkill : ISkill
    {
        private readonly Context context;
        public RepositorySkill(IUnitOfWork uow)
        {
            context = uow.Context as Context;
        }
        public void SuperSkill()
        {
            throw new NotImplementedException();
        }

        IQueryable<RepositorySkill> IRepository<RepositorySkill>.All
        {
            get { throw new NotImplementedException(); }
        }

        RepositorySkill IRepository<RepositorySkill>.Find(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(RepositorySkill entity)
        {
            throw new NotImplementedException();
        }

        public void Update(RepositorySkill entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
           
        }
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
