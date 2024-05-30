using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Binabox.Persistence.Configurations;

public class RoadMapConfiguration : IEntityTypeConfiguration<RoadMap>
{
    public void Configure(EntityTypeBuilder<RoadMap> builder)
    {
        builder.HasMany(r => r.RoadMapBenefits)
            .WithOne(rb => rb.RoadMap)
            .HasForeignKey(rb => rb.RoadMapId);
    }
}