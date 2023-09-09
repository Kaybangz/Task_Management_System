namespace INFRASTRUCTURE.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        Task SaveAsync();
    }
}
