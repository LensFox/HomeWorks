using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace _10_ThreeLayerProject.PL.Middleware
{
    public class LogMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<LogMiddleware> logger;
        public LogMiddleware(RequestDelegate next, ILogger<LogMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            finally
            {
                if(context.Response?.StatusCode / 100 != 2)
                {
                    logger.LogInformation("LOG MIDDLEWARE");
                    logger.LogError("Request {method} {url} => {statusCode}",
                     context.Request?.Method,
                     context.Request?.Path.Value,
                     context.Response?.StatusCode);
                }
            }
        }
    }
}

