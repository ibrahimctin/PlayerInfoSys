namespace PlayerInfoSys.Domain.Common.Abstraction.Messaging
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
         where TQuery : IQuery<TResponse>
    {
    }
}
