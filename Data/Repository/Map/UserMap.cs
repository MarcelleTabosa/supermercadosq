using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(150);
            builder.Property(x => x.SocialName).HasMaxLength(10);
            builder.Property(x => x.CpfCnpj).IsRequired().HasMaxLength(11);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Level).IsRequired();
            builder.Property(x => x.Active).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(11);
            builder.Property(x => x.AddressId).IsRequired();
            builder.HasOne(x => x.Address);
        }
    }
}