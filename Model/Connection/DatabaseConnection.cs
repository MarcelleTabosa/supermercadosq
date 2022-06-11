using Microsoft.EntityFrameworkCore;
using supermercadosq.Entities;

namespace supermercadosq.Model.Connection{
    public class DatabaseConnection : DbContext{
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}