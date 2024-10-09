using Application.Facade;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.Exceptions;

namespace API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomerController(IFunctionsManager functionsManager) : ControllerBase
    {
        protected readonly IFunctionsManager _functionsManager = functionsManager;

        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Customer/all
        ///
        /// </remarks>
        /// <response code="200">Customers returned successfully.</response>
        [HttpGet("all")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await _functionsManager.Customer.GetAllCustomersAsync();
        }

        /// <summary>
        /// Search customer by ssn, company, name, address, email or phone number
        /// </summary>
        /// <returns>List of customers that match the search word</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Customer/search?query=John
        ///     GET /api/Customer/search?query=556677-8899
        ///     GET /api/Customer/search?query=Storgatan
        ///
        /// </remarks>
        /// <response code="200">Customers returned successfully.</response>
        /// <response code="400">Bad request or invalid query.</response>
        [HttpGet("search")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<List<Customer>> SearchCustomer([FromQuery] string query)
        {
            if ((string.IsNullOrEmpty(query)))
            {
                throw new InvalidParameterException("Query can not be null or empty string.");
            }
            return await _functionsManager.Customer.SearchCustomerAsync(query);
        }
    }
}
