using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository.Map
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.Message).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UserId).IsRequired();
            builder.HasOne(x => x.User);
            builder.Property(x => x.ProductId).IsRequired();
            builder.HasOne(x => x.Product);
        }
    }
}
