using AspNetExercise2.Middlewares.Contracts;

namespace AspNetExercise2.Services.Extensions;

public static class TimeCheckServiceExtension
{
    public static IServiceCollection AddTimeChecking
    (this IServiceCollection services)
    {
        services.AddSingleton<ITimeCheckService, TimeCheckService>();

        return services;
    }
}
