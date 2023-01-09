using System.Net;
using Microsoft.AspNetCore.Diagnostics;

namespace Ecommerce.Middleware;

public static class ExceptionMiddlewareExtensions
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                if (contextFeature != null)
                {
                    await context.Response.WriteAsJsonAsync(new
                    {
                        StatusCode = (HttpStatusCode)context.Response.StatusCode,
                        Message = "Internal Server Error."
                    });
                }
            });
        });
    }
}