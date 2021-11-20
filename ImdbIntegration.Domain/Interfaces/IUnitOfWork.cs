using System;
using System.Collections.Generic;
using System.Text;

namespace ImdbIntegration.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void Save();
    }
}
