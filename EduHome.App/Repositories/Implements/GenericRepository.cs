using EduHome.App.context;
using EduHome.App.Models.BaseModel;
using EduHome.App.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace EduHome.App.Repositories.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly EduHomeDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(EduHomeDbContext context)
        {
            _context = new EduHomeDbContext();
            _dbSet = _context.Set<T>();
        }
        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry entityEntry = await _context.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public bool Delete(T entity)
        {
            EntityEntry entityEntry = _context.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<IQueryable<T>> GetAllAsync(
           System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public async Task<T>? GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).FirstOrDefaultAsync();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(T entity)
        {
            EntityEntry entry = _dbSet.Update(entity);
            return entry.State == EntityState.Modified;
        }
    }
}
