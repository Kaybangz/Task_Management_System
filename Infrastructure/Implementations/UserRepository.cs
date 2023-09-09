using DOMAIN.Entities;
using INFRASTRUCTURE.DatabaseContext;
using INFRASTRUCTURE.Interfaces;

namespace INFRASTRUCTURE.Implementations
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {

        public UserRepository(TaskManagementSystemDbContext dbContext)
            : base(dbContext)
        {}


        public async Task CreateUser(User user) => await AddAsync(user);

        public void DeleteUser(User user) => Delete(user);

        public async Task<User> GetUser(Guid id) => await GetByIdAsync(id);

        public async Task<IEnumerable<User>> GetUsersAsync() => await GetAllAsync();

        public void UpdateUser(User user) => Update(user);
    }
}
