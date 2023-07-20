using Microsoft.EntityFrameworkCore;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly DatabaseConnection _connection;

        public UserRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<User>> GetAll()
        {
            return await _connection.Users.ToListAsync();
        }

        public async Task<User> Get(int id)
        {
            return await _connection.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> Post(User entity)
        {
            _connection.Users.Add(entity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<User> Put(User entity, int id)
        {
            var updateEntity = await Get(id);

            if (updateEntity == null)
                throw new Exception($"User ID: {id} not found.");

            updateEntity.Name = entity.Name;
            updateEntity.SocialName = entity.SocialName;
            updateEntity.Email = entity.Email;
            updateEntity.Password = entity.Password;
            updateEntity.Level = entity.Level;
            updateEntity.Active = entity.Active;
            updateEntity.PhoneNumber = entity.PhoneNumber;
            updateEntity.UpdateDate = DateTime.Now;

            _connection.Update(updateEntity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var deleteEntity = await Get(id);

            if (deleteEntity == null)
                throw new Exception($"User ID: {id} not found.");

            _connection.Remove(deleteEntity);
            _connection.SaveChanges();
            return true;
        }
    }
}
