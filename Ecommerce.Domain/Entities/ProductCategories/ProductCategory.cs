using Ecommerce.Domain.Entities.Products;
using Ecommerce.SharedLib.Domain.Comman;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Entities.ProductCategories
{
    public class ProductCategory : AduitEntity<int>
    {
        public int? CategoryID { get; set; }
        [MaxLength(200)]

        public string CategoryName { get; set; } = string.Empty;
        [MaxLength(300)]

        public string Description { get; set; } = string.Empty;

        public ICollection<Product> Products { get; set; } = [];
    }
}
