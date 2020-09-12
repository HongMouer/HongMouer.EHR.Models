using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Abstractions;

namespace HongMouer.Common
{
    public sealed class AuthenticationMiddlerware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddlerware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {


            string authentication = context.Request.Headers["token"];
            //string key = context.Request.Headers["key"];
            //string key = context.Request.Headers["key"];
            string RedirectUrl = context.Request.Query["RedirectUrl"];
            //if (context.Request.RouteValues["controller"].ToString() == "Account")
            //{
            //    await _next.Invoke(context);
            //}
            if (context.Request.Path.StartsWithSegments("/Account"))
            {
                await _next.Invoke(context);
            }
            else if (!string.IsNullOrWhiteSpace(authentication))
            {

                /*
                 * 根据用户账号密码验证用户有效性
                 * 如果有效
                 * 执行 await _next.Invoke(context);
                 * 否则
                 * context.Response.StatusCode = 401;
                 */

                if (true)
                {
                    await _next.Invoke(context);
                }
                else
                {
                    context.Response.StatusCode = 401;
                    context.Response.Redirect($"/Account/login?RedirectUrl={RedirectUrl}");
                    //context.Response.
                }
            }
            else
            {
                context.Response.StatusCode = 401;
                context.Response.Redirect($"/Account/login?RedirectUrl={RedirectUrl}");
            }

        }
    }

    public static class AuthenticationMiddlerwareExtension
    {
        public static IApplicationBuilder UseBasicAuthenticationMiddlerware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthenticationMiddlerware>();
        }
    }
}
