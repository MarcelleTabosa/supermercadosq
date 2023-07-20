using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository.Map
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Ingredient).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UserId).IsRequired();
            builder.HasOne(x => x.User);
        }
    }
}
