﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HongMouer.Common
{
    public class PerformanceMiddleware
    {
        private static IRepository _Context = new OracleRepository("DefaultConnection");

        public static IApplicationBuilder UsePerformanceLog(this IApplicationBuilder applicationBuilder)

        {
            applicationBuilder.Use(async (context, next) =>
            {

                var profiler = new StopwatchAnalyze();
                profiler.Start();
                await next();
                profiler.Stop();

                SaveMonitor(new ServiceMonitor
                {
                    ConnectionId = context.Connection.Id,
                    HostName = Dns.GetHostName(),
                    ClientIP = context.Connection.RemoteIpAddress.ToString(),
                    Port = context.Connection.RemotePort,
                    TraceIdentifier = context.TraceIdentifier,
                    Method = context.Request.Method,
                    Path = context.Request.Path,
                    Times = profiler.ElapsedMilliseconds,
                    StatusCode = context.Response.StatusCode,
                    CreateTime = DateTime.Now
                });

            });

            return applicationBuilder;

        }

        private static void SaveMonitor(ServiceMonitor monitor)
        {
            //try
            //{
            _Context.InsertAsync(monitor);
            //}
            //catch (Exception ex) { }
        }
    }
}