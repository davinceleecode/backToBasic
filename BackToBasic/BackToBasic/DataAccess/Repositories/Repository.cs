using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackToBasic.DataAccess.Entities;
namespace BackToBasic.DataAccess.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : EntityBase
    {

        public virtual List<T> Get()
        {
            throw new NotImplementedException();
        }

        public virtual T Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual T Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public virtual int Delete(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
