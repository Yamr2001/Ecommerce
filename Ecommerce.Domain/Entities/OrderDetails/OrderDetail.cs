using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.OrderDetails
{
    public class OrderDetail : AduitEntity<int>
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Order Order { get; set; } = default!;
        public Product Product { get; set; } = default!;
    }

}
