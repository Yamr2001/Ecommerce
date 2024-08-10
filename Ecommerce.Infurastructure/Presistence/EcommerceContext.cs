using Ecommerce.Domain.Entities.Inventories;
using Ecommerce.Domain.Entities.OrderDetails;
using Ecommerce.Domain.Entities.Orders;
using Ecommerce.Domain.Entities.Payments;
using Ecommerce.Domain.Entities.Prescriptions;
using Ecommerce.Domain.Entities.ProductCategories;
using Ecommerce.Domain.Entities.Products;
using Ecommerce.Domain.Entities.Reviews;
using Ecommerce.Domain.Entities.Shippings;
using Ecommerce.Domain.Entities.Users;
using Ecommerce.SharedLib.Domain.Comman.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infurastructure.Presistence
{
    public class EcommerceContext(DbContextOptions<EcommerceContext> options) : DbContext(options)
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<IAduitEntity>()) {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        break;
                }


            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
