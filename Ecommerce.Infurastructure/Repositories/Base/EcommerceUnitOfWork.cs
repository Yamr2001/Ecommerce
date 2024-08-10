using Ecommerce.Domain.Entities.Inventories;
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
