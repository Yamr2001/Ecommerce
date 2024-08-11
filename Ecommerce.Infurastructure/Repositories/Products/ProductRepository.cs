using Ecommerce.SharedLib.Infurasturcture;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Domain.Entities.Products
{
    public class ProductRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<Product>(contextAccessor, entites), IProductRepository
    {
    }
}
