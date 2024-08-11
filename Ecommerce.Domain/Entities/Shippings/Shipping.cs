using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Shippings
{
    public class Shipping : AduitEntity<int>
    {
        public int? OrderID { get; set; }
        [MaxLength(200)]
        public string ShippingMethod { get; set; } = string.Empty;
        [MaxLength(200)]
        public string TrackingNumber { get; set; } = string.Empty;
        public DateTime? EstimatedDeliveryDate { get; set; } = default!;

        [ForeignKey(nameof(OrderID))]

        public Order Order { get; set; } = default!;
    }

}
