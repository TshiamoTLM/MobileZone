using MobileZone.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileZone.Data
{
    public interface IRepositoryBase<T>
    {
        T GetById(int id);
        IEnumerable<T> FindAll();
       
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
