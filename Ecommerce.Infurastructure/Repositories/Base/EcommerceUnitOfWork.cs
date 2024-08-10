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
using Ecommerce.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infurastructure.Repositories.Base
{
    public class EcommerceUnitOfWork : IEcommerceUnitOfWork
    {
        public IInventoryRepository InventoryRepository => throw new NotImplementedException();

        public IProductCategoryRepository ProductCategoryRepository => throw new NotImplementedException();

        public IOrderDetailRepository OrderDetailRepository => throw new NotImplementedException();

        public IShippingRepository ShippingRepository => throw new NotImplementedException();

        public IProductRepository ProductRepository => throw new NotImplementedException();

        public IReviewRepository ReviewRepository => throw new NotImplementedException();

        public IPaymentRepository PaymentRepository => throw new NotImplementedException();

        public IUserRepository UserRepository => throw new NotImplementedException();

        public IOrderRepository OrderRepository => throw new NotImplementedException();

        public IPrescriptionRepository ReplyRepository => throw new NotImplementedException();

        public Task Complete()
        {
            throw new NotImplementedException();
        }

        public Task CompleteWithAudit(string adminUserId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
