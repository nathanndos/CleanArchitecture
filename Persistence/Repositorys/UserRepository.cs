using Domain.Entities;
using Domain.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repositorys.Base;

namespace Persistence.Repositorys
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        { }

        public async Task<User> getByEmail(string email, CancellationToken cancellationToken)
        {
            return await context.Users.FirstOrDefaultAsync(i => i.Email == email, cancellationToken);
        }
    }
}
