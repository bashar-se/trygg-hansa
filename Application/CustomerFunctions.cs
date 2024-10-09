using Application.Facade;
using Domain.Entities;
using Domain.Repositories;

namespace Application
{
    public class CustomerFunctions : ICustomerFunctions
    {
        private readonly IRepositoryManager _repository;
        public CustomerFunctions(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            return await _repository.Customer.GetAllCustomersAsync();
        }

        public async Task<List<Customer>> SearchCustomerAsync(string query)
        {
            return await _repository.Customer.SearchCustomerAsync(query);
        }
    }
}
