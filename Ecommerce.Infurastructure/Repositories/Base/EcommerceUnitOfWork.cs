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
using Ecommerce.Infurastructure.Presistence;
using Ecommerce.SharedLib.Domain.Comman.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infurastructure.Repositories.Base
{
    public class EcommerceUnitOfWork(IHttpContextAccessor contextAccessor, EcommerceContext context) : IEcommerceUnitOfWork
    {
        private readonly IHttpContextAccessor _contextAccessor = contextAccessor;
        private readonly EcommerceContext _context = context;


        private IInventoryRepository _inventoryRepository;
        public IInventoryRepository InventoryRepository
        {

            get {
                return _inventoryRepository ??= new InventoryRepository(_contextAccessor, _context);

            }
        }
        private IProductCategoryRepository _productCategoryRepository;
        public IProductCategoryRepository ProductCategoryRepository
        {

            get
            {
                return _productCategoryRepository ??= new ProductCategoryRepository(_contextAccessor, _context);

            }
        }
        private IOrderDetailRepository _prderDetailRepository;
        public IOrderDetailRepository OrderDetailRepository
        {

            get
            {
                return _prderDetailRepository ??= new OrderDetailRepository(_contextAccessor, _context);

            }
        }
        private IShippingRepository _shippingRepository;
        public IShippingRepository ShippingRepository
        {

            get
            {
                return _shippingRepository ??= new ShippingRepository(_contextAccessor, _context);

            }
        }
        public IProductRepository _productRepository;
        public IProductRepository ProductRepository
        {

            get
            {
                return _productRepository ??= new ProductRepository(_contextAccessor, _context);

            }
        }
        private IReviewRepository _reviewRepository;
        public IReviewRepository ReviewRepository
        {

            get
            {
                return _reviewRepository ??= new ReviewRepository(_contextAccessor, _context);

            }
        }
        private IPaymentRepository _paymentRepository;
        public IPaymentRepository PaymentRepository
        {

            get
            {
                return _paymentRepository ??= new PaymentRepository(_contextAccessor, _context);

            }
        }
        private IUserRepository _userRepository;
        public IUserRepository UserRepository
        {

            get
            {
                return _userRepository ??= new UserRepository(_contextAccessor, _context);

            }
        }
        private IOrderRepository _orderRepository;
        public IOrderRepository OrderRepository
        {

            get
            {
                return _orderRepository ??= new OrderRepository(_contextAccessor, context);

            }
        }
        private IPrescriptionRepository _replyRepository;
        public IPrescriptionRepository ReplyRepository
        {

            get
            {
                return _replyRepository ??= new PrescriptionRepository(_contextAccessor, context);

            }
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }

        public async Task CompleteWithAudit(string adminUserId)
        {
            foreach (var entity in _context.ChangeTracker.Entries())
            {
                if (entity.Entity is IAduitEntity myEntity)
                {
                    if (entity.State == EntityState.Added)
                    {
                        myEntity.CreatedDate = DateTime.Now;// DateTimeHelper.GetLocalDateTime();
                        myEntity.Createdby = adminUserId != null ? Guid.Parse(adminUserId) : null;
                    }

                    if (entity.State == EntityState.Modified)
                    {
                        myEntity.UpdatedDate = DateTime.Now; //DateTimeHelper.GetLocalDateTime();
                        myEntity.Updatedby = adminUserId != null ? Guid.Parse(adminUserId) : null;
                    }
                }
            }

            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
