using Domain.Entities;

namespace Storage.Facade
{
    public interface ICustomerContext
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<List<Customer>> SearchCustomerAsync(string query);
    }
}
