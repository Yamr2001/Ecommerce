using Ecommerce.SharedLib.Infurasturcture;
using Ecommerce.SharedLib.Infurasturcture.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Domain.Entities.Inventories
{
    public class InventoryRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<Inventory>(contextAccessor, entites), IInventoryRepository
    {
    }
}
