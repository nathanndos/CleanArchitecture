using Domain.Entities;
using Domain.Interfaces.Repositorys.BaseRepositoy;

namespace Domain.Interfaces.Repositorys
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> getByEmail(string email, CancellationToken cancellationToken);
    }
}