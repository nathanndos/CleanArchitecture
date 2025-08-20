using Domain.Entities.Abstract;
using Domain.Interfaces.Repositorys.BaseRepositoy;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositorys.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext context;

        public BaseRepository(AppDbContext context)
        {
            this.context = context;
        }

        public void create(T entity)
        {
            entity.DateCreated = DateTimeOffset.UtcNow;
            context.Add(entity);
        }

        public void delete(T entity)
        {
            entity.DateDeleted = DateTimeOffset.UtcNow;
            context.Remove(entity);
        }

        public async Task<T> get(Guid ide, CancellationToken cancellationToken)
        {
            return await context.Set<T>().FirstOrDefaultAsync(i => i.Ide == ide, cancellationToken);
        }

        public async Task<List<T>> getAll(CancellationToken cancellationToken)
        {
            return await context.Set<T>().ToListAsync(cancellationToken);
        }

        public void update(T entity)
        {
            entity.DateUpdated = DateTimeOffset.UtcNow;
            context.Update(entity);
        }
    }
}
