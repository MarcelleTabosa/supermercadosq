using Microsoft.EntityFrameworkCore;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly DatabaseConnection _connection;

        public ProductRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _connection.Products.ToListAsync();
        }

        public async Task<Product> Get(int id)
        {
            return await _connection.Products.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> Post(Product entity)
        {
            _connection.Products.Add(entity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<Product> Put(Product entity, int id)
        {
            var updateEntity = await Get(id);

            if (updateEntity == null)
                throw new Exception($"Product ID: {id} not found.");

            updateEntity.Name = entity.Name;
            updateEntity.Ingredient = entity.Ingredient;
            updateEntity.Image = entity.Image;
            updateEntity.Status = entity.Status;
            updateEntity.UpdateDate = DateTime.Now;

            _connection.Update(updateEntity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var deleteEntity = await Get(id);

            if (deleteEntity == null)
                throw new Exception($"Product ID: {id} not found.");

            _connection.Remove(deleteEntity);
            _connection.SaveChanges();
            return true;
        }
    }
}
