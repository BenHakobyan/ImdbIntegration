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

            builder.Property(x => x.FilmId).HasMaxLength(9);

            builder.HasKey(x => new { x.UserId, x.FilmId });
        }
    }
}
