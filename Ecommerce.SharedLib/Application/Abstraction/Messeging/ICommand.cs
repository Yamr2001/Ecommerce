using MediatR;

namespace Ecommerce.SharedLib.Application.Abstraction.Messeging
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
