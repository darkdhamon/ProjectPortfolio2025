using Microsoft.EntityFrameworkCore;
using Model.Entity.Abstract;

namespace Model.Repositories;

public class Repository<T> : IRepository<T> where T : AEntity
{
    protected readonly PortfolioContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(PortfolioContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

    public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity is null) return;
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
