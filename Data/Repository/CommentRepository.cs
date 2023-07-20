using Microsoft.EntityFrameworkCore;
using supermercadosq.Data.Interfaces;
using supermercadosq.Domain;

namespace supermercadosq.Data.Repository
{
    public class CommentRepository : IRepository<Comment>
    {
        private readonly DatabaseConnection _connection;

        public CommentRepository(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Comment>> GetAll()
        {
            return await _connection.Comments.ToListAsync();
        }

        public async Task<Comment> Get(int id)
        {
            return await _connection.Comments.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Comment> Post(Comment entity)
        {
            _connection.Comments.Add(entity);
            _connection.SaveChanges();
            return entity;
        }

        public async Task<Comment> Put(Comment entity, int id)
        {
            var updateEntity = await Get(id);

            if (updateEntity == null)
                throw new Exception($"Comment ID: {id} not found.");

            updateEntity.Message = entity.Message;
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
                throw new Exception($"Comment ID: {id} not found.");

            _connection.Remove(deleteEntity);
            _connection.SaveChanges();
            return true;
        }
    }
}
