namespace API.Errors
{
    public class ApiException // class contain the response of what are we going to send back to the client when we have an exception
    {
        public ApiException(int statusCode, string message, string details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        public string Details { get; set; }
    }
}