using Binabox.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Binabox.Persistence.Configurations;

public class ShopItemConfiguration : IEntityTypeConfiguration<ShopItem>
{
    public void Configure(EntityTypeBuilder<ShopItem> builder)
    {
        builder.HasKey(x => x.Id);
            
        builder.HasOne(i => i.ItemDetail)
            .WithOne(x => x.ShopItem)
            .HasForeignKey<ItemDetail>(x => x.ItemId)
            .HasPrincipalKey<ShopItem>(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}