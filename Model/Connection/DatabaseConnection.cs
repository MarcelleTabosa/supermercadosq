using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Model.Connection{
    public class DatabaseConnection : DbContext{
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Product>().Property( p => p.Ingredient).HasMaxLength(255);
            builder.Entity<Comment>().Property( c => c.Message).HasMaxLength(255);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder){
            builder.Properties<string>().HaveMaxLength(100);
        }
    }
}