using System;
using System.Collections.Generic;
using System.Text;

namespace Mvlsz.Persistance.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> CreateRepository<T>() where T : class;
        void Save();
    }
}
