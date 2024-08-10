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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces
{
    public interface IEcommerceUnitOfWork : IDisposable
    {
        IInventoryRepository InventoryRepository { get; }
        IProductCategoryRepository ProductCategoryRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        IShippingRepository ShippingRepository { get; }
        IProductRepository ProductRepository { get; }
        IReviewRepository ReviewRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IUserRepository UserRepository { get; }
        IOrderRepository OrderRepository { get; }
        IPrescriptionRepository ReplyRepository { get; }
        Task Complete();

        Task CompleteWithAudit(string adminUserId);
    }
}
