using System.Net;

namespace Ecommerce.Middleware;

public class ResponseMiddleware
{
    private readonly RequestDelegate _next;

    public ResponseMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await _next(context);

        if (context.Response.StatusCode == (int)HttpStatusCode.Unauthorized)
        {
            await context.Response.WriteAsJsonAsync(new
            {
                StatusCode = HttpStatusCode.Unauthorized,
                Message = "Unauthorized"
            });
        }

        if (context.Response.StatusCode == (int)HttpStatusCode.Forbidden)
        {
            await context.Response.WriteAsJsonAsync(new
            {
                StatusCode = HttpStatusCode.Forbidden,
                Message = "Forbidden"
            });
        }
    }
}