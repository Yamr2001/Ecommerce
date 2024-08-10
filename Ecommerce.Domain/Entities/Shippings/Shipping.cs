using Ecommerce.Domain.Entities.Orders;

namespace Ecommerce.Domain.Entities.Shippings
{
    public class Shipping
    {
        public int ShippingID { get; set; }
        public int OrderID { get; set; }
        public string ShippingMethod { get; set; } = string.Empty;
        public string TrackingNumber { get; set; } = string.Empty;
        public DateTime EstimatedDeliveryDate { get; set; } = default!;

        public Order Order { get; set; } = default!;
    }

}
