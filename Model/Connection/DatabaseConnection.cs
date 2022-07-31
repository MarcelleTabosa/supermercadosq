using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Model.Connection{
    public class DatabaseConnection : DbContext{
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder){
            builder.Properties<string>().HaveMaxLength(100);
        }
    }
}