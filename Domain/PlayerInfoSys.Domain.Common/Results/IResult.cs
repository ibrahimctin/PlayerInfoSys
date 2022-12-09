namespace PlayerInfoSys.Domain.Common.Results
{
    public interface IResult
    {
        int StatusCode { get; }
        string Message { get; }
    }
}
