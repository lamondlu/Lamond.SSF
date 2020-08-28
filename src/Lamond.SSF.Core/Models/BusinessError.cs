namespace Lamond.SSF.Core.Models
{
    public abstract class BusinessError
    {
        public int ErrorCode
        {
            get;
            private set;
        }

        public string Message
        {
            get;
            private set;
        }

        public BusinessError(int errorCode, string message)
        {
            ErrorCode = errorCode;
            Message = message;
        }
    }
}