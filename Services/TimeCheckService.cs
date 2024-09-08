using AspNetExercise2.Middlewares.Contracts;

namespace AspNetExercise2.Services;

public class TimeCheckService : ITimeCheckService
{
    public bool Check()
                    => (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 16);
}

