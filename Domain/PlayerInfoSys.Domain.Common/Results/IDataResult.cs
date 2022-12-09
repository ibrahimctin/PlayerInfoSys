namespace PlayerInfoSys.Domain.Common.Results
{
  
    internal interface IDataResult<out T> : IResult
    {
        T Data { get; }
        int TotalRecords { get; }
    }
}
