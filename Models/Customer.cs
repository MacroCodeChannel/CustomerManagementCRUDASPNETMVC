using System.ComponentModel;

namespace CustomerManagementSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        public required string Name { get; set; }

        [DisplayName("Email Address")]
        public required string Email { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; } = string.Empty;

        [DisplayName("City")]
        public string City { get; set; } = string.Empty;

        [DisplayName("Region")]
        public string Region { get; set; } = string.Empty;

        [DisplayName("Postal Code")]
        public string PostalCode { get; set; } = string.Empty;

        [DisplayName("Country")]
        public string Country { get; set; } = string.Empty;

        [DisplayName("Phone Number")]
        public required string PhoneNumber { get; set; }

        [DisplayName("Fax")]
        public string Fax { get; set; } = string.Empty;

        [DisplayName("VAT Number")]
        public string VATNumber { get; set;} = string.Empty;


    }
}
