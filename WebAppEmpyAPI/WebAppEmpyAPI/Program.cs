var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//APP 초기화후 초기 설정
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
        await context.Response.WriteAsync("홈페이지 입니다.");
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
