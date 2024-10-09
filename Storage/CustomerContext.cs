using Domain.Entities;
using Storage.Facade;
using System.Reflection;

namespace Storage
{
    public class CustomerContext : ICustomerContext
    {
        private readonly static List<Customer> Customers = [];
        public CustomerContext() { }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            if (Customers.Count == 0)
            {
                await ReadAllCustomersFromTextFileAsync(GetFilePath());
            }
            return await Task.FromResult(Customers);
        }

        public async Task<List<Customer>> SearchCustomerAsync(string query)
        {
            query = query.ToLower();
            var _customers = new List<Customer>();
            await GetAllCustomersAsync();
            foreach (var customer in Customers)
            {
                if (customer.SSN.Contains(query) || 
                    customer.Company.ToLower().Contains(query) ||
                    customer.FirstName.ToLower().Contains(query) ||
                    customer.LastName.ToLower().Contains(query) ||
                    customer.Address.Street.ToLower().Contains(query) ||
                    customer.Address.PostalCode.Contains(query) ||
                    customer.Address.City.ToLower().Contains(query) ||
                    customer.Email.ToLower().Contains(query) || 
                    customer.Phone.Contains(query))
                {
                    _customers.Add(customer);
                }
            }
            return await Task.FromResult(_customers);
        }

        private static string GetFilePath()
        {
            Assembly? assembly = Assembly.GetEntryAssembly();
            var basePath = Path.GetDirectoryName(assembly?.Location);
            return $"{basePath}\\Files\\Testfil.txt";
        }

        private static async Task<List<Customer>> ReadAllCustomersFromTextFileAsync(string filePath)
        {
            var lines = await File.ReadAllLinesAsync(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 7)
                {
                    var customer = new Customer
                    {
                        SSN = parts[0],
                        Company = parts[1],
                        FirstName = parts[2].Split(' ')[0],
                        LastName = parts[2].Split(' ')[1],
                        Address = new Address
                        {
                            Street = parts[3],
                            PostalCode = parts[4].Trim().Split(' ')[0] + parts[4].Trim().Split(' ')[1],
                            City = parts[4].Trim().Split(' ')[2]
                        },
                        Email = parts[5],
                        Phone = parts[6]
                    };
                    Customers.Add(customer);
                }
            }
            return Customers;
        }
    }
}
