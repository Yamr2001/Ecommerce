using Ecommerce.Domain.Entities.Orders;
using Ecommerce.SharedLib.Domain.Comman;
using Ecommerce.SharedLib.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Payments
{
    public class Payment : AduitEntity<int>
    {
        public int? OrderID { get; set; }
        public DateTime? PaymentDate { get; set; }
        public PaymentMehods? PaymentMethod { get; set; } 
        public decimal? Amount { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } = default!;
    }

}
