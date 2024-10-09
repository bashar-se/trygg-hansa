using Domain.Entities;
using Domain.Repositories;
using Moq;
using Repository.Test.Mock;
using Storage.Facade;

namespace Repository.Test
{
    public class CustomerRepositoryTest
    {
        private readonly Mock<ICustomerContext> _customerContextMock;
        private readonly ICustomerRepository _customerRepository;
        public CustomerRepositoryTest()
        {
            _customerContextMock = new Mock<ICustomerContext>();
            _customerRepository = new CustomerRepository(_customerContextMock.Object);
        }

        [Fact]
        public async Task CustomerRepositoryCallGetAllCustomers_GetAllCustomersMethodIsCalled()
        {
            //Arrange
            //Act
            await _customerRepository.GetAllCustomersAsync();
            //Assert
            _customerContextMock.Verify(c => c.GetAllCustomersAsync(), Times.Once);
        }

        [Fact]
        public async Task GetAllCustomersViaCustomerRepository_ReturnsMockedListOfAllCustomers()
        {
            //Arrange
            _customerContextMock.Setup(c=>c.GetAllCustomersAsync()).ReturnsAsync(MockData.Customers);
            //Act
            var customers = await _customerRepository.GetAllCustomersAsync();
            //Assert
            Assert.NotNull(customers);
            Assert.Equal(22, customers.Count);
            Assert.IsType<List<Customer>>(customers);
        }

        [Fact]
        public async Task CustomerRepositoryCallSearchCustomer_SearchCustomerMethodIsCalled()
        {
            //Arrange
            string query = "test";
            //Act
            await _customerRepository.SearchCustomerAsync(query);
            //Assert
            _customerContextMock.Verify(c => c.SearchCustomerAsync(It.IsAny<string>()), Times.Once);
        }
    }
}