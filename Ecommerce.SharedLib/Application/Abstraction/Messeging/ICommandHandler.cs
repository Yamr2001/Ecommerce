using MediatR;

namespace Ecommerce.SharedLib.Application.Abstraction.Messeging
{
    public interface ICommandHandler<in TCommand,TResponse> : IRequestHandler<TCommand,TResponse> where TCommand : ICommand<TResponse>
    {
    }
}
