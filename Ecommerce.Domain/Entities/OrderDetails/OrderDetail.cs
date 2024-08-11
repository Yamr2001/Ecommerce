using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.OrderDetails
{
    public class OrderDetail : AduitEntity<int>
    {
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        [ForeignKey(nameof(OrderID))]
        public Order Order { get; set; } = default!;
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = default!;
    }

}
