using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Binabox.Persistence.Configurations;

public class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.HasMany(a => a.AboutCounters)
            .WithOne(ac => ac.About)
            .HasForeignKey(ac => ac.AboutId);
        
        builder.HasMany(a => a.AboutStats)
            .WithOne(st => st.About)
            .HasForeignKey(st => st.AboutId);
    }
}