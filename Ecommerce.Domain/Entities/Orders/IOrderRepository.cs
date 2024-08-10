using Ecommerce.SharedLib.Infurasturcture.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Orders
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
