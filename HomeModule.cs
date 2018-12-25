using System;
using Botwin;
using Microsoft.AspNetCore.Http;

namespace SimpleInfoServer
{
    public class HomeModule : BotwinModule
    {

        public HomeModule()
        {
            Get("/", async (req, res, routeData) => await res.WriteAsync($"Server: {Environment.MachineName}"));
        }
    }
}
