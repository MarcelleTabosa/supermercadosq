using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository.Map
{
    public class EntityMap : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreationDate).IsRequired();
        }
    }
}