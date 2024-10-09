using Domain.Entities;

namespace Repository.Test.Mock
{
    public static class MockData
    {
        public static List<Customer> Customers = new()
        {
            new() {
                SSN = "556677-8899",
                Company = "Kund AB",
                FirstName = "Anders",
                LastName = "Andersson",
                Address = new Address {
                    Street = "Storgatan 1",
                    PostalCode = "12345",
                    City = "Staden"
                },
                Email = " anders.andersson@kundab.se",
                Phone = " 123-456789"
            },
            new() {
                SSN = "556677-8899",
                Company = "Kund AB",
                FirstName = "Anders",
                LastName = "Andersson",
                Address = new Address {
                  Street = "Storgatan 1",
                  PostalCode = "12345",
                  City = "Staden"
                },
                Email = " info@kundab.se",
                Phone = " 987-654321"
              },
               new() {
                SSN = "223344-5566",
                Company = "Testföretaget AB",
                FirstName = "Lisa",
                LastName = "Svensson",
                Address = new Address {
                  Street = "Gatan 2",
                  PostalCode = "54321",
                  City = "Staden"
                },
                Email = " lisa@testforetaget.se",
                Phone = " 987-654321"
              },
              new() {
                SSN = "998877-6655",
                Company = "Exempel Company",
                FirstName = "Anna",
                LastName = "Karlsson",
                Address = new Address {
                  Street = "Vägen 3",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " anna.karlsson@examplecompany.com",
                Phone = " 456-789012"
              },
              new() {
                SSN = "998877-6655",
                Company = "Exempel Company",
                FirstName = "Stina",
                LastName = "Nilsson",
                Address = new Address {
                  Street = "Vägen 3",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " stina.N@examplecompany.com",
                Phone = " 345-678901"
              },
              new() {
                SSN = "998877-6655",
                Company = "Exempel Company",
                FirstName = "Stina",
                LastName = "Nilsson",
                Address = new Address {
                  Street = "Vägen 3",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " support@examplecompany.com",
                Phone = " 345-678901"
              },
              new() {
                SSN = "112233-4455",
                Company = "Provföretaget AB",
                FirstName = "Per",
                LastName = "Nilsson",
                Address = new Address {
                  Street = "Allégatan 4",
                  PostalCode = "21054",
                  City = "Staden"
                },
                Email = " per@provforetaget.se",
                Phone = " 789-012345"
              },
              new() {
                SSN = "112233-4455",
                Company = "Provföretaget AB",
                FirstName = "Per",
                LastName = "Nilsson",
                Address = new Address {
                  Street = "Allégatan 4",
                  PostalCode = "21054",
                  City = "Staden"
                },
                Email = " sales@provforetaget.se",
                Phone = " 678-901234"
              },
              new() {
                SSN = "334455-6677",
                Company = "Fiktivt Företag AB",
                FirstName = "Maria",
                LastName = "Eriksson",
                Address = new Address {
                  Street = "Hörnet 5",
                  PostalCode = "54321",
                  City = "Staden"
                },
                Email = " maria.fiktivt@foretaget.se",
                Phone = " 345-678901"
              },
              new() {
                SSN = "334455-6677",
                Company = "Fiktivt Företag AB",
                FirstName = "Maria",
                LastName = "Eriksson",
                Address = new Address {
                  Street = "Hörnet 5",
                  PostalCode = "54321",
                  City = "Staden"
                },
                Email = " info@foretaget.se",
                Phone = " 901-234567"
              },
              new() {
                SSN = "556633-9911",
                Company = "Dummy Company",
                FirstName = "Erik",
                LastName = "Johansson",
                Address = new Address {
                  Street = "Vägen 6",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " erik.dummy@company.se",
                Phone = " 678-901234"
              },
              new() {
                SSN = "556633-9911",
                Company = "Dummy Company",
                FirstName = "Erik",
                LastName = "Johansson",
                Address = new Address {
                  Street = "Vägen 6",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " support@company.se",
                Phone = " 567-890123"
              },
              new() {
                SSN = "556677-8899",
                Company = "Kund AB",
                FirstName = "Anders",
                LastName = "Andersson",
                Address = new Address {
                  Street = "Storgatan 1",
                  PostalCode = "12345",
                  City = "Staden"
                },
                Email = " anders.andersson@kundab.se",
                Phone = " 123-456789"
              },
              new() {
                SSN = "223344-5566",
                Company = "Testföretaget AB",
                FirstName = "Lisa",
                LastName = "Svensson",
                Address = new Address {
                  Street = "Gatan 2",
                  PostalCode = "54321",
                  City = "Staden"
                },
                Email = " lisa@testforetaget.se",
                Phone = " 987-654321"
              },
              new() {
                SSN = "998877-6655",
                Company = "Exempel Company",
                FirstName = "Anna",
                LastName = "Karlsson",
                Address = new Address {
                  Street = "Vägen 3",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " anna.karlsson@examplecompany.com",
                Phone = " 456-789012"
              },
              new() {
                SSN = "112233-4455",
                Company = "Provföretaget AB",
                FirstName = "Per",
                LastName = "Nilsson",
                Address = new Address {
                  Street = "Allégatan 4",
                  PostalCode = "21054",
                  City = "Staden"
                },
                Email = " per@provforetaget.se",
                Phone = " 789-012345"
              },
              new() {
                SSN = "334455-6677",
                Company = "Fiktivt Företag AB",
                FirstName = "Maria",
                LastName = "Eriksson",
                Address = new Address {
                  Street = "Hörnet 5",
                  PostalCode = "54321",
                  City = "Staden"
                },
                Email = " maria.fiktivt@foretaget.se",
                Phone = " 345-678901"
              },
              new() {
                SSN = "556633-9911",
                Company = "Dummy Company",
                FirstName = "Erik",
                LastName = "Johansson",
                Address = new Address {
                  Street = "Vägen 6",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " erik.dummy@company.se",
                Phone = " 678-901234"
              },
              new() {
                SSN = "778899-1122",
                Company = "Test Company",
                FirstName = "Karin",
                LastName = "Gustafsson",
                Address = new Address {
                  Street = "Gatan 7",
                  PostalCode = "12345",
                  City = "Staden"
                },
                Email = " karin.testcompany@company.com",
                Phone = " 901-234567"
              },
              new() {
                SSN = "443322-5566",
                Company = "Exempelföretaget AB",
                FirstName = "Anders",
                LastName = "Svensson",
                Address = new Address {
                  Street = "Storgatan 8",
                  PostalCode = "21054",
                  City = "Staden"
                },
                Email = " anders@exempelforetaget.se",
                Phone = " 234-567890"
              },
              new() {
                SSN = "665544-8877",
                Company = "Sample Company",
                FirstName = "Lisa",
                LastName = "Karlsson",
                Address = new Address {
                  Street = "Gatan 9",
                  PostalCode = "54321",
                  City = "Staden"
                },
                Email = " lisa.sample@company.se",
                Phone = " 567-890123"
              },
              new() {
                SSN = "990011-2233",
                Company = "ABC Företaget AB",
                FirstName = "Mattias",
                LastName = "Lindqvist",
                Address = new Address {
                  Street = "Vägen 10",
                  PostalCode = "67890",
                  City = "Staden"
                },
                Email = " mattias@abcforetaget.se",
                Phone = " 890-123456"
              }
        };
    }
}
