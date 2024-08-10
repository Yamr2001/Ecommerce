using Ecommerce.Domain.Entities.Orders;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.Shippings
{
    public class Shipping : AduitEntity<int>
    {
        public int OrderID { get; set; }
        public string ShippingMethod { get; set; } = string.Empty;
        public string TrackingNumber { get; set; } = string.Empty;
        public DateTime EstimatedDeliveryDate { get; set; } = default!;

        public Order Order { get; set; } = default!;
    }

}
