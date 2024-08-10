using Ecommerce.SharedLib.Domain.Comman;
using Ecommerce.SharedLib.Domain.Comman.Interfaces;
using Ecommerce.SharedLib.Infurasturcture.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Ecommerce.SharedLib.Infurasturcture
{
    public class Repository<T>(IHttpContextAccessor contextAccessor, DbContext entites) : IRepository<T> where T : AduitEntity<int>
    {
        private readonly IHttpContextAccessor _contextAccessor = contextAccessor;
        private readonly DbSet<T> _entites = entites.Set<T>();

        protected string CurrentUser => _contextAccessor.HttpContext.User.Identity.Name;

        protected string UserId => _contextAccessor.HttpContext != null ? (_contextAccessor.HttpContext.User.Claims
                       .First(i => i.Type == ClaimTypes.NameIdentifier).Value) : "";
        public async Task<T> AddAsync(int orgId, string contextName, T entity)
        {
            if(typeof(IAduitEntity).IsAssignableFrom(typeof(T)))
            {
                var aduit = (IAduitEntity)entity;
                aduit.SetCreator(UserId,DateTime.UtcNow);
            }
            await _entites.AddAsync(entity);
            return entity;
        }

        public Task<IEnumerable<T>> AddRangeAsync(int orgId, string contextName, IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckIfEntityExistsAsync(int orgId, Expression<Func<T, bool>> expr)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int orgId, string contextName, T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRangeAsync(int orgId, string contextName, IEnumerable<T> entites)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int orgId, string contextName, int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(int orgId, string contextName, T entity)
        {
            if (typeof(IAduitEntity).IsAssignableFrom(typeof(T)))
            {
                var audit = (IAduitEntity)entity;
                audit.SetUpdator(UserId, DateTime.UtcNow);
            }
        }
    }
}
