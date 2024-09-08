using AspNetExercise2.Middlewares.Extensions;
using AspNetExercise2.Services.Extensions;

namespace AspNetExercise2.HostingExtension;

public static class WebHostingExtension
{
    public static WebApplication ConfigureServices
        (this WebApplicationBuilder builder)
    {
        builder.Services.AddTimeChecking();

        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseTimeLimitation();
        app.MapGet("/", () => "Welcome to our website!!");

        return app;
    }
}
