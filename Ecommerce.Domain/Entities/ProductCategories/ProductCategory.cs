using Ecommerce.Domain.Entities.Products;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.ProductCategories
{
    public class ProductCategory : AduitEntity<int>
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = [];
    }
}
