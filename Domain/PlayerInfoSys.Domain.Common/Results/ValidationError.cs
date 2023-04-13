namespace PlayerInfoSys.Domain.Common.Results
{
    public class ValidationError:IResult
    {
        public string Field { get; set; }

        public int StatusCode { get; set; }

        public string Message { get; set; } 
        public ValidationError(string field,string message)
        {
            Field = field;
            Message = message;
        }
    }
}
