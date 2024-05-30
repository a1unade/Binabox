using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Binabox.Persistence.Configurations;

public class ItemDetailsConfiguration : IEntityTypeConfiguration<ItemDetail>
{
    public void Configure(EntityTypeBuilder<ItemDetail> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasMany(i => i.ItemCategories)
            .WithOne(x => x.ItemDetail)
            .HasPrincipalKey(x => x.Id)
            .HasForeignKey(x => x.ItemDetailId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}