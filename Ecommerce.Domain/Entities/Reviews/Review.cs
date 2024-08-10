using Ecommerce.Domain.Entities.Products;
using Ecommerce.SharedLib.Domain.Comman;

namespace Ecommerce.Domain.Entities.Reviews
{
    public class Review : AduitEntity<int>
    {
        public int ReviewID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public int Rating { get; set; } // Rating 1-5
        public string Comment { get; set; } = string.Empty;
        public DateTime ReviewDate { get; set; }

        public User User { get; set; }
        public Product Product { get; set; } = default!;
    }

}
