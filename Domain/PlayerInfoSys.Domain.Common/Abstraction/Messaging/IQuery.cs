namespace PlayerInfoSys.Domain.Common.Abstraction.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
