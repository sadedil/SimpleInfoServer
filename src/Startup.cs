using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleInfoServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCarter();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseCarter();
        }
    }
}