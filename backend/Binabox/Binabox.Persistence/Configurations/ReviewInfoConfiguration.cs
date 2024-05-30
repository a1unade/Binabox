using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Binabox.Persistence.Configurations;

public class ReviewInfoConfiguration : IEntityTypeConfiguration<ReviewInfo>
{
    public void Configure(EntityTypeBuilder<ReviewInfo> builder)
    {
        builder.HasMany(a => a.Reviews)
            .WithOne(r => r.ReviewInfo)
            .HasForeignKey(r => r.ReviewInfoId);
    }
}