using Domain.Repositories;
using Storage.Facade;

namespace Repository.Facade
{
    public class RepositoryManager : IRepositoryManager
    {
        private ICustomerRepository? _customer;
        private readonly ICustomerContext _customerContext;

        public RepositoryManager(ICustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public ICustomerRepository Customer
        {
            get
            {
                _customer ??= new CustomerRepository(_customerContext);
                return _customer;
            }
        }
    }
}
