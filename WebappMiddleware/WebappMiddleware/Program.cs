var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("Main입니다\n");
    await next(context);
});

app.Use(async(context , next) =>
{ await context.Response.WriteAsync("안녕하세요\n");
    await next(context);
});


app.Run(async (context) =>
{
    await context.Response.WriteAsync("ASP.NET Core! 공부합시다");
});
app.Run();
