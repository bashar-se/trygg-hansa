namespace Domain.Entities
{
    public class Customer
    {
        public required string SSN { get; set; }
        public required string Company { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required Address Address { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
    }
}
