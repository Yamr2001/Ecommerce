using MediatR;

namespace Ecommerce.SharedLib.Application.Abstraction.Messeging
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
