namespace API.Middleware
{
    public class ExceptionMiddleware
    {
        readonly RequestDelegate _next;
        readonly ILogger<ExceptionMiddleware> _logger;

        readonly IHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
        {
            _env = env;
            _logger = logger;
            _next = next;
        }
    }
}