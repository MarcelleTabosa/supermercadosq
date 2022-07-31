using Microsoft.EntityFrameworkCore;
using supermercadosq.Domain;

namespace supermercadosq.Model.Connection{
    public class DatabaseConnection : DbContext{
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder){
            builder.Properties<string>().HaveMaxLength(100);
        }
    }
}