using Ecommerce.SharedLib.Infurasturcture;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Domain.Entities.OrderDetails
{
    public class OrderDetailRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<OrderDetail>(contextAccessor, entites), IOrderDetailRepository
    {
    }
}
