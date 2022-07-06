using MobileZone.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public abstract class EFRepositoryBase<T>:IRepositoryBase<T> where T:class
    {
        protected MobileDbContext _mobileDbContext;
        public EFRepositoryBase(MobileDbContext mobileDbContext)
        {
            _mobileDbContext = mobileDbContext;
        }

        public void Add(T entity)
        {
            _mobileDbContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _mobileDbContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _mobileDbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _mobileDbContext.Set<T>().Find(id);
        }


        public void Update(T entity)
        {
            _mobileDbContext.Set<T>().Update(entity);
        }
    }
}
