using Ecommerce.Domain.Entities.Inventories;
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
        Task Complete();

        Task CompleteWithAudit(string adminUserId);
    }
}
