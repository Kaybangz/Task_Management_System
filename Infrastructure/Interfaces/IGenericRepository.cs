using System.Linq.Expressions;

namespace INFRASTRUCTURE.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAllByConditionAsync(Expression<Func<T, bool>> predicate);
        Task<T> GetByIdAsync(Guid Id);
        Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
