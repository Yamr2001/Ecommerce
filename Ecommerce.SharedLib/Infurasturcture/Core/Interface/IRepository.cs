using Ecommerce.SharedLib.Domain.Comman;
using System.Linq.Expressions;

namespace Ecommerce.SharedLib.Infurasturcture.Core.Interface
{
    public interface IRepository <T> where T : EntityBase<int>
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int orgId, string contextName, int id);
        Task<T> AddAsync(int orgId, string contextName, T entity);
        Task UpdateAsync(int orgId, string contextName, T entity);
        Task DeleteAsync(int orgId, string contextName, T entity);
        Task<bool> CheckIfEntityExistsAsync(int orgId, Expression<Func<T, bool>> expr);
        Task<IEnumerable<T>> AddRangeAsync(int orgId, string contextName, IEnumerable<T> entities);
        Task DeleteRangeAsync(int orgId, string contextName, IEnumerable<T> entites);
    }
}
