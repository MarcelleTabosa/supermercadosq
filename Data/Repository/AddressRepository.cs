using Microsoft.EntityFrameworkCore;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository
{
    public class AddressRepository : IRepository<Address>
    {
        private readonly DatabaseConnection _connection;

        public AddressRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Address>> GetAll()
        {
            return await _connection.Addresses.ToListAsync();
        }

        public async Task<Address> Get(int id)
        {
            return await _connection.Addresses.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Address> Post(Address entity)
        {
            _connection.Addresses.Add(entity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<Address> Put(Address entity, int id)
        {
            var updateEntity = await Get(id);

            if (updateEntity == null)
                throw new Exception($"Address ID: {id} not found.");

            updateEntity.Road = entity.Road;
            updateEntity.Number = entity.Number;
            updateEntity.District = entity.District;
            updateEntity.City = entity.City;
            updateEntity.State = entity.State;

            _connection.Update(updateEntity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            var deleteEntity = await Get(id);

            if (deleteEntity == null)
                throw new Exception($"Address ID: {id} not found.");

            _connection.Remove(deleteEntity);
            _connection.SaveChanges();
            return true;
        }
    }
}
