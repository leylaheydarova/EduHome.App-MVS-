using EduHome.App.Models.BaseModel;

namespace EduHome.App.Repositories.Interfaces
{
    public interface IGenericRepository<T>where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        Task<T> GetAsync(System.Linq.Expressions.Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>>predicate);
        Task<int> SaveAsync();
        int Save();

    }
}
