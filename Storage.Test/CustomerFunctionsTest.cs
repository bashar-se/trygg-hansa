using Domain.Entities;
using Storage.Facade;
using Storage.Test.Mock;

namespace Storage.Test
{
    public class CustomerFunctionsTest
    {
        private readonly CustomerContext _customerContext;
        public CustomerFunctionsTest()
        {
            _customerContext = new CustomerContext();
        }

        [Fact]
        public async Task GetAllCustomers_ReturnsListOfAllCustomers()
        {
            // Arrange
            // Act
            var customers = await _customerContext.GetAllCustomersAsync();
            // Assert
            Assert.NotNull(customers);
            Assert.Equal(22, customers.Count);
            Assert.IsType<List<Customer>>(customers);
        }

        [Theory]
        [InlineData(MockData.SSN)]
        [InlineData(MockData.Company)]
        [InlineData(MockData.FirstName)]
        [InlineData(MockData.LastName)]
        [InlineData(MockData.Street)]
        [InlineData(MockData.PostalCode)]
        [InlineData(MockData.City)]
        [InlineData(MockData.Email)]
        [InlineData(MockData.Phone)]
        public async Task SearchCustomer_QueryStringExists_ReturnsNoneEmptyListOfCustomers(string query)
        {
            // Arrange
            // Act
            var customers = await _customerContext.SearchCustomerAsync(query);
            // Assert
            Assert.True(customers.Count > 0);
            Assert.IsType<List<Customer>>(customers);
        }

        [Theory]
        [InlineData(MockData.WrongSSN)]
        [InlineData(MockData.WrongCompany)]
        [InlineData(MockData.WrongFirstName)]
        [InlineData(MockData.WrongLastName)]
        [InlineData(MockData.WrongStreet)]
        [InlineData(MockData.WrongPostalCode)]
        [InlineData(MockData.WrongCity)]
        [InlineData(MockData.WrongEmail)]
        [InlineData(MockData.WrongPhone)]
        public async Task SearchCustomer_QueryStringDoesNotExist_ReturnsEmptyListOfCustomers(string query)
        {
            // Arrange
            // Act
            var customers = await _customerContext.SearchCustomerAsync(query);
            // Assert
            Assert.False(customers.Count > 0);
        }
    }
}