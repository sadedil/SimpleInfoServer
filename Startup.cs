using Botwin;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleInfoServer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddBotwin();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseBotwin();
        }
    }
}
