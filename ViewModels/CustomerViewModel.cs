using CustomerManagementSystem.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomerManagementSystem.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage ="Please Provide Valid Customer Name")]
        public  string Name { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Please Provide Valid Customer Email Address")]
        [EmailAddress]
        public string Email { get; set; }

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
        public string VATNumber { get; set; } = string.Empty;

        public Customer Customer { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
