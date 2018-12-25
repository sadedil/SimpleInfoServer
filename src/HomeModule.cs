using Carter;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;

namespace SimpleInfoServer
{
    public class HomeModule : CarterModule
    {
        public HomeModule(IConfiguration configuration)
        {
            Get("/", async (req, res, routeData) =>
            {
                var version = configuration.GetSection("Version").Value;
                await res.WriteAsync($"Server: {Environment.MachineName}, Version: {version}");
            });

            Get("/healthcheck", async (req, res, routeData) =>
            {
                res.StatusCode = 200;
                await res.WriteAsync("OK");
            });
        }
    }
}