using AspNetExercise2.HostingExtension;
using AspNetExercise2.Middlewares.Extensions;
using AspNetExercise2.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder
    .ConfigureServices()
    .ConfigurePipeline(); 

app.Run();
