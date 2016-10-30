using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);

            //app.UseMiddleware<MeuExemploMiddleware>(loggerFactory);
            app.UseMeuExemplo(loggerFactory);

            app.Run(async (context) => 
            {
                await context.Response.WriteAsync("Olá Pessoal - Respondendo via Startup ;)");
            });
        }
    }
}