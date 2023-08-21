var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//APP �ʱ�ȭ�� �ʱ� ����
//app.UseRouting();

//app.MapGet("/Hi", () => "main page");

//app.MapGet("/home", () => "HelloWorld~Get");
//app.MapPost("/home", () => "HelloWorld~Post");
//app.MapPut("/home", () => "HelloWorld~Put");
//app.MapDelete("/home", () => "HelloWorld~Delete");

app.UseEndpoints(async endpoints =>
{
    endpoints.MapGet("/Home", async (context) =>
    {
        context.Response.ContentType = "text/plain; charset=utf-8";
        await context.Response.WriteAsync("Ȩ������ �Դϴ�.");
    });
    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Post.");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Put");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Delete");
    });

});



app.Run();
