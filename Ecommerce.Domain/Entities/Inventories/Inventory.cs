using Ecommerce.Domain.Entities.Products;
using Ecommerce.SharedLib.Domain.Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Inventories
{
    public class Inventory : AduitEntity<int>
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime LastRestockedDate { get; set; } = default!;

        public Product Product { get; set; } = default!;
    }

}
