using Domain.Entities.Abstract;

namespace Domain.Interfaces.Repositorys.BaseRepositoy
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void create(T entity);
        void update(T entity);
        void delete(T entity);
        Task<T> get(Guid ide, CancellationToken cancellationToken);
        Task<List<T>> getAll(CancellationToken cancellationToken);
    }
}
