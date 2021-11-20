using ImdbIntegration.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImdbIntegration.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IImdbContext _dbContext;
        private Dictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork(IImdbContext dbContext)
        {
            _dbContext = dbContext;
            _repositories = new Dictionary<Type, object>();
            _disposed = false;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.Keys.Contains(typeof(TEntity)))
                return _repositories[typeof(TEntity)] as IRepository<TEntity>;

            var repository = new Repository<TEntity>(_dbContext);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                this._disposed = true;
            }
        }
    }
}