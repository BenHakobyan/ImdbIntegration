using ImdbIntegration.Domain.Interfaces;
using ImdbIntegration.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ImdbIntegration.Infrastructure
{
    public class ImdbContext : DbContext, IImdbContext
    {
        public ImdbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ImdbContext).Assembly);
        }

        public DbSet<WatchListItem> WatchListItems { get; set; }
    }
}
