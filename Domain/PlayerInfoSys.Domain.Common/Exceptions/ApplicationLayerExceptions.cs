namespace PlayerInfoSys.Domain.Common.Exceptions
{
    public class ApplicationLayerExceptions:Exception
    {
        public string Message { get; set; }
        public ApplicationLayerExceptions(string message)
        {
            Message = message;  
        }
    }
}
