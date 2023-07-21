using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository.Map
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.Road).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Number).IsRequired().HasMaxLength(10);
            builder.Property(x => x.District).IsRequired().HasMaxLength(150);
            builder.Property(x => x.City).IsRequired().HasMaxLength(150);
            builder.Property(x => x.State).IsRequired().HasMaxLength(150);
        }
    }
}
