namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        ICustomerRepository Customer { get; }
    }
}
