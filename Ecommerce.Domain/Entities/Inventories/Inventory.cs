using Ecommerce.Domain.Entities.Products;
using Ecommerce.SharedLib.Domain.Comman;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Inventories
{
    public class Inventory : AduitEntity<int>
    {
        public int? ProductID { get; set; }
        public int? Quantity { get; set; }
        public DateTime? LastRestockedDate { get; set; } = default!;
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = default!;
    }

}
