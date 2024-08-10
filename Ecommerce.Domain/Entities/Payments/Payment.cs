using Ecommerce.Domain.Entities.Orders;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.Payments
{
    public class Payment : AduitEntity<int>
    {
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal, COD
        public decimal Amount { get; set; }

        public Order Order { get; set; } = default!;
    }

}
