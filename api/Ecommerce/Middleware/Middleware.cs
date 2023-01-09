namespace Ecommerce.Middleware;

public static class Middleware
{
    public static IApplicationBuilder UseResponseMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ResponseMiddleware>();
    }
}