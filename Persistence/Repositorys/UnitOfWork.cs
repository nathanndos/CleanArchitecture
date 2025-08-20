using Domain.Interfaces.Repositorys.BaseRepositoy;
using Persistence.Context;

namespace Persistence.Repositorys
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;

        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
