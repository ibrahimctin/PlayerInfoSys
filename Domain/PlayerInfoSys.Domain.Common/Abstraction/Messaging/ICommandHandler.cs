namespace PlayerInfoSys.Domain.Common.Abstraction.Messaging
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
     where TCommand : ICommand<TResponse>
    {
    }
}
