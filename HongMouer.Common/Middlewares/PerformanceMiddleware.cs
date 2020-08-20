using HongMouer.EHR.Models;
using HongMouer.EntityRelationalCore.Repositories;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HongMouer.Common.Utility;

namespace HongMouer.Common
{
    public static class PerformanceMiddleware
    {

        public static IApplicationBuilder UseSystemMonitor(this IApplicationBuilder app, IRepository repository)
        {
            
            app.Use(async (context, next) =>
            {
                var profiler = new StopwatchAnalyze();
                profiler.Start();
                await next();
                profiler.Stop();

               await repository.InsertAsync(new SystemMonitor
                {
                    ConnectionId = context.Connection.Id,
                    HostName = Dns.GetHostName(),
                    ClientIP = context.Connection.RemoteIpAddress.ToString(),
                    Port = context.Connection.RemotePort,
                    TraceIdentifier = context.TraceIdentifier,
                    Method = context.Request.Method,
                    Path = context.Request.Path,
                    Times = profiler.ElapsedMilliseconds,
                    Status = context.Response.StatusCode,
                    CreateTime = DateTime.Now
                });
            });

            return app;
        }
    }
}