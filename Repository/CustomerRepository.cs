using Domain.Entities;
using Domain.Repositories;
using Storage.Facade;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerContext _customerContext;
        public CustomerRepository(ICustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {            
            return await _customerContext.GetAllCustomersAsync();
        }

        public async Task<List<Customer>> SearchCustomerAsync(string query)
        {
            return await _customerContext.SearchCustomerAsync(query);
        }
    }
}
