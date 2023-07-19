namespace supermercadosq.Data.Interfaces
{
    public interface IRepository<T> 
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Post(T entity);
        Task<T> Put(T entity, int id);
        Task<bool> Delete(int id);
    }
}
