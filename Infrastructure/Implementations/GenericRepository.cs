using INFRASTRUCTURE.DatabaseContext;
using INFRASTRUCTURE.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace INFRASTRUCTURE.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TaskManagementSystemDbContext _dbContext;

        public GenericRepository(TaskManagementSystemDbContext context)
        {
            _dbContext = context;
        }

        public async Task AddAsync(T entity) => 
            await _dbContext.Set<T>().AddAsync(entity);

        public void Delete(T entity) => 
            _dbContext.Set<T>().Remove(entity);

        public async Task<IEnumerable<T>> FindAllByConditionAsync(Expression<Func<T,
            bool>> predicate) => await _dbContext
            .Set<T>()
            .Where(predicate)
            .ToListAsync();
       

        public async Task<T> FindByConditionAsync(Expression<Func<T,
            bool>> predicate) =>
            await _dbContext
            .Set<T>()
            .FirstOrDefaultAsync(predicate);

        public async Task<IEnumerable<T>> GetAllAsync() => 
            await _dbContext
            .Set<T>()
            .ToListAsync();

#pragma warning disable CS8603 // Possible null reference return.
        public async Task<T> GetByIdAsync(Guid Id) => 
            await _dbContext.Set<T>().FindAsync(Id);
#pragma warning restore CS8603 // Possible null reference return.

        public void Update(T entity) => 
            _dbContext.Set<T>().Update(entity);
    }
}
