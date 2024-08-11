using Ecommerce.SharedLib.Infurasturcture;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Domain.Entities.Users
{
    public class UserRepository(IHttpContextAccessor contextAccessor, DbContext entites) : Repository<User>(contextAccessor, entites), IUserRepository
    {
    }
}
