using Ecommerce.Domain.Entities.OrderDetails;
using Ecommerce.Domain.Entities.Payments;
using Ecommerce.Domain.Entities.Shippings;
using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.Orders
{
    public class Order : AduitEntity<int>
    {
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // e.g., Pending, Shipped, Delivered, Canceled
        public string ShippingAddress { get; set; } = string.Empty;
        public int PaymentID { get; set; }

        public User User { get; set; } = default!;
        public Payment Payment { get; set; } = default!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
        public Shipping Shipping { get; set; } = default!;
    }

}
