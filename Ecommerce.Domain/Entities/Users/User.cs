using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Prescriptions;
using Ecommerce.Domain.Entities.Reviews;
using Ecommerce.SharedLib.Domain.Comman;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities.Users
{
    public class User : AduitEntity<int>
    {
        [MaxLength(300)]
        public string Username { get; set; } = string.Empty;    
        public string PasswordHash { get; set; } = string.Empty;
        [MaxLength(200)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [MaxLength(12)]
        [DataType(DataType.EmailAddress)]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // e.g., Customer, Admin, Pharmacist

        public ICollection<Order> Orders { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<Prescription> Prescriptions { get; set; } = [];
    }

}
