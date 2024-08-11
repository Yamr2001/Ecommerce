using Ecommerce.Domain.Entities.OrderDetails;
using Ecommerce.Domain.Entities.Payments;
using Ecommerce.Domain.Entities.Shippings;
using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;
using Ecommerce.SharedLib.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Orders
{
    public class Order : AduitEntity<int>
    {
        public int? UserID { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public Status? Status { get; set; }
        [MaxLength(300)]
        public string ShippingAddress { get; set; } = string.Empty;
        public int? PaymentID { get; set; }
        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = default!;
        [ForeignKey(nameof(PaymentID))]
        public Payment Payment { get; set; } = default!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
        public Shipping Shipping { get; set; } = default!;
    }

}
