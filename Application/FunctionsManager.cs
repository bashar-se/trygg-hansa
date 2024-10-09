using Application.Facade;
using Domain.Repositories;

namespace Application
{
    public class FunctionsManager : IFunctionsManager
    {
        private readonly IRepositoryManager _repository;
        private ICustomerFunctions? _customer;

        public FunctionsManager(IRepositoryManager repository)
        {
            _repository = repository;
        }

        public ICustomerFunctions Customer
        {
            get
            {
                _customer ??= new CustomerFunctions(_repository);
                return _customer;
            }
        }
    }
}
