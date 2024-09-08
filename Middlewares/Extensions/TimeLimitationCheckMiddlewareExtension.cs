namespace AspNetExercise2.Middlewares.Extensions;

public static class TimeLimitationCheckMiddlewareExtension
{
    public static IApplicationBuilder UseTimeLimitation(
        this IApplicationBuilder app)
    {
        app.UseMiddleware<TimeLimitationCheckMiddleware>();

        return app;
    }
}
