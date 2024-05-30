using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Binabox.Persistence.Configurations;

public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.HasMany(s => s.SubscriptionProperties)
            .WithOne(sp => sp.Subscription)
            .HasForeignKey(sp => sp.SubscriptionId);
    }
}