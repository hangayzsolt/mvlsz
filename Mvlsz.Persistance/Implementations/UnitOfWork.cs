using System;
using System.Collections.Generic;
using System.Text;
using Mvlsz.Persistance.Entities;
using Mvlsz.Persistance.Interfaces;

namespace Mvlsz.Persistance.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MvlszContext _context;

        public UnitOfWork(MvlszContext context)
        {
            _context = context;
        }

        public IRepository<T> CreateRepository<T>() where T : class
        {
            return new Repository<T>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        #region IDisposable Support
        private bool _disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposedValue = true;
            }
        }

        ~UnitOfWork()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
