using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Prescriptions;
using Ecommerce.Domain.Entities.Reviews;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.Users
{
    public class User : AduitEntity<int>
    {
        public string Username { get; set; } = string.Empty;    
        public string PasswordHash { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // e.g., Customer, Admin, Pharmacist

        public ICollection<Order> Orders { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<Prescription> Prescriptions { get; set; } = [];
    }

}
