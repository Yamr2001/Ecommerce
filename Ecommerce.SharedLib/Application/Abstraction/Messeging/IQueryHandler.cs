using MediatR;

namespace Ecommerce.SharedLib.Application.Abstraction.Messeging
{
    public interface IQueryHandler<in TQuery ,TResponse> : IRequestHandler<TQuery,TResponse> where TQuery : IQuery<TResponse>
    {
    }
}
