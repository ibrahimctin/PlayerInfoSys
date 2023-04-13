namespace PlayerInfoSys.Domain.Common.Results
{
  
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
        int TotalRecords { get; }
    }
}
