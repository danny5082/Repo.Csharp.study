var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Run(async (context) =>
{
    context.Response.ContentType = "rext/html; charset=utf-8";
    await context.Response.WriteAsync("<table border='1'>" +
        "<tr>" +
            "<td>����</td>" +
            "<td>������</td>" +
        "<tr>" +
        "<tr>" +
            "<td>����</td>" +
            "<td>23</td>" +
        "<tr>" +
        "<table>");

});

app.Run();
