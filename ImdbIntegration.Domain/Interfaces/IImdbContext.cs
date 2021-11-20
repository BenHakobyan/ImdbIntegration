using ImdbIntegration.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ImdbIntegration.Domain.Interfaces
{
    public interface IImdbContext
    {
        DbSet<WatchListItem> WatchListItems { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
        void Dispose();
    }
}
