using AspNetExercise2.Middlewares.Contracts;

namespace AspNetExercise2.Middlewares;

public class TimeLimitationCheckMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ITimeCheckService _timeCheckService;

    public TimeLimitationCheckMiddleware(
        RequestDelegate next,
        ITimeCheckService timeCheckService)
    {
        this._next = next;
        this._timeCheckService = timeCheckService;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!_timeCheckService.Check())
        {
            await context.Response.WriteAsync
                         ("You can use our web site from 8am to 4pm!!!");
        }
        else
        {
            await _next(context);
        }
    }
}
