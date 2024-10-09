using Domain.Entities;

namespace Application.Facade
{
    public interface ICustomerFunctions
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<List<Customer>> SearchCustomerAsync(string query);
    }
}
