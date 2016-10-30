using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) => 
            {
                await context.Response.WriteAsync("Olá Pessoal - Respondendo via Startup ;)");
            });
        }
    }
}