var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/plain; charset=utf-8";
    await context.Response.WriteAsync("Main�Դϴ�\n");
    await next(context);
});

app.Use(async(context , next) =>
{ await context.Response.WriteAsync("�ȳ��ϼ���\n");
    await next(context);
});


app.Run(async (context) =>
{
    await context.Response.WriteAsync("ASP.NET Core! �����սô�");
});
app.Run();
