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
                var machineName = Environment.MachineName;
                var version = configuration.GetSection("Version").Value;
                var now = DateTime.Now.ToString();
                await res.WriteAsync($"Server: <b>{machineName}</b>, Version: <b>{version}</b>, Date: <b>{now}</b>");
            });

            Get("/healthcheck", async (req, res, routeData) =>
            {
                res.StatusCode = 200;
                await res.WriteAsync("OK");
            });
        }
    }
}
