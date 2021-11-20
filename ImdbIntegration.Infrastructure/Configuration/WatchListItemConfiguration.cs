using ImdbIntegration.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImdbIntegration.Infrastructure.Configuration
{
    public class WatchListItemConfiguration : IEntityTypeConfiguration<WatchListItem>
    {
        public void Configure(EntityTypeBuilder<WatchListItem> builder)
        {
            builder.ToTable("WatchListItems");

            builder.HasKey(x => new { x.UserId, x.FilmId });
        }
    }
}
