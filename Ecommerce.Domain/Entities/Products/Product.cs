using Ecommerce.Domain.Entities.Inventories;
using Ecommerce.Domain.Entities.OrderDetails;
using Ecommerce.Domain.Entities.ProductCategories;
using Ecommerce.Domain.Entities.Reviews;
using Ecommerce.SharedLib.Domain.Comman;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Products
{
    public class Product : AduitEntity<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; } = string.Empty;

        public ProductCategory Category { get; set; } = default!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = [];
        public ICollection<Inventory> Inventories { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
    }
}
