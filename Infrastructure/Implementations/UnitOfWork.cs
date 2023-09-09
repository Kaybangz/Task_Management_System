using INFRASTRUCTURE.DatabaseContext;
using INFRASTRUCTURE.Interfaces;

namespace INFRASTRUCTURE.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskManagementSystemDbContext _dbContext;

        public UnitOfWork(TaskManagementSystemDbContext context)
        {
            _dbContext = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing) 
        { 
            if(disposing)
                _dbContext.Dispose();
        }

        public async Task SaveAsync() => await _dbContext.SaveChangesAsync();
    }
}
