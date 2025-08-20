namespace Domain.Interfaces.Repositorys.BaseRepositoy
{
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}
