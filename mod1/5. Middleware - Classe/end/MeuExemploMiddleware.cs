using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class MeuExemploMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public MeuExemploMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<MeuExemploMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            _logger.LogInformation($"Recebendo request: {context.Request.GetDisplayUrl()}");
            await _next.Invoke(context);
            _logger.LogInformation("Terminado a captura do request.");
        }
    }

    public static class MeuExemploMiddlewareExtensions
    {
        public static void UseMeuExemplo(this IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.UseMiddleware<MeuExemploMiddleware>(loggerFactory);
        }
    }
}