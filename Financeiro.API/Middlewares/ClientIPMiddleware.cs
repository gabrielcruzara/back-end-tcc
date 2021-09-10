using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Financeiro.API.Middlewares
{
    public class ClientIPMiddleware
    {
        // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
            private readonly RequestDelegate _next;
            private readonly ILogger _logger;


            public ClientIPMiddleware(RequestDelegate next, ILoggerFactory logFactory)
            {
                _next = next;
                _logger = logFactory.CreateLogger("ClientIPMiddleware");

            }

            public Task Invoke(HttpContext httpContext)
            {
                _logger.LogInformation("IP Middleware executing..");
                var ip = httpContext.Connection.RemoteIpAddress.ToString();
                var browserInfo = httpContext.Request.Headers["User-Agent"].ToString();

                _logger.LogInformation($"IP: {ip}");
                _logger.LogInformation($"Navegador: { browserInfo}");

                return _next(httpContext);
            }
    }

        // Extension method used to add the middleware to the HTTP request pipeline.
        public static class ClientIPMiddlewareExtensions
        {
            public static IApplicationBuilder UseClientIPMiddleware(this IApplicationBuilder builder)
            {
                return builder.UseMiddleware<ClientIPMiddleware>();
            }
        }
}
