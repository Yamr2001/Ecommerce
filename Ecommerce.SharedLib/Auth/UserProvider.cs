using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Ecommerce.SharedLib.Auth
{
    public class UserProvider(IHttpContextAccessor context) : IUserProvider
    {
        private readonly IHttpContextAccessor _context = context;

        public Guid GetUserId()
        {
            return
           Guid.Parse(_context.HttpContext.User.Claims.First(i=>i.Type == ClaimTypes.NameIdentifier).Value);
        }
    }
}
