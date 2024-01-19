using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinimalCakeShop_Models.CakeModels;

namespace MinimalCakeShop.Infrastructure.EntityConfiguration
{
    public class CakeShopEntityTypeConfiguration : IEntityTypeConfiguration<CakeShop>
    {
        public void Configure(EntityTypeBuilder<CakeShop> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ShopName).IsRequired();

            builder.Property(x => x.ShoDescription).IsRequired();   

            builder.Property(x => x.CreatedOn).IsRequired();
        }
    }
}
