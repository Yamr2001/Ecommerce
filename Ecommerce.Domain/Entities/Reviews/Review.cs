using Ecommerce.Domain.Entities.Products;
using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Domain.Entities.Reviews
{
    public class Review : AduitEntity<int>
    {
        public int? UserID { get; set; }
        public int? ProductID { get; set; }
        public int? Rating { get; set; } // Rating 1-5
        [MaxLength(200)]
        public string Comment { get; set; } = string.Empty;
        public DateTime? ReviewDate { get; set; } = default!;
        [ForeignKey(nameof(UserID))]
        public User User { get; set; } = default!;
        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = default!;
    }

}
