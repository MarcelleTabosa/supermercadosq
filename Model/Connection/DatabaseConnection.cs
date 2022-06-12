using Microsoft.EntityFrameworkCore;
using supermercadosq.Entities;

namespace supermercadosq.Model.Connection{
    public class DatabaseConnection : DbContext{
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<User>()
            .Property( u => u.Name).HasMaxLength(100).IsRequired(true);
            builder.Entity<User>()
            .Property(u => u.SocialName).HasMaxLength(100).IsRequired(false);
        }
    }
}