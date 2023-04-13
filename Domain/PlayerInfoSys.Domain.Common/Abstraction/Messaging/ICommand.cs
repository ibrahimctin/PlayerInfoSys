namespace PlayerInfoSys.Domain.Common.Abstraction.Messaging
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
