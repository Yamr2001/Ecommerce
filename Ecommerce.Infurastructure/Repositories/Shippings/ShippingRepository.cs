using Ecommerce.SharedLib.Infurasturcture;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Domain.Entities.Shippings
{
    public class ShippingRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<Shipping>(contextAccessor, entites), IShippingRepository
    {
    }
}
