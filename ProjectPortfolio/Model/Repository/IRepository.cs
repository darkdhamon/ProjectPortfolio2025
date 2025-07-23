namespace Model.Repository;

using Model.Entity.Abstract;

public interface IRepository<T> where T : AEntity
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}
