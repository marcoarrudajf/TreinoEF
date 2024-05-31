using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TreinoEF.Infra.Repositories.Interfaces;

namespace TreinoEF.Infra.Repositories
{
    public class BaseRepository<T, TKey> : IBaseRepositories<T, TKey> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly DbContext _context;
        public BaseRepository(TreinoEFContext context)
        {
            _dbSet = context.Set<T>();
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<T> Get(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }
        public T Add(T entity)
        {
            return _dbSet.Add(entity).Entity;
        }
        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public T Delete(T entity)
        {
            return _dbSet.Remove(entity).Entity;
        }



        public T Update(T entity)
        {
            return _dbSet.Update(entity).Entity;
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

    }
}
