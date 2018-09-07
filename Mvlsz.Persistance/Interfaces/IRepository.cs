using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvlsz.Persistance.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        T GetById(Guid id);
        List<T> GetAll();
        IQueryable<T> CreateQuery();
        void Delete(T entity);
    }
}
