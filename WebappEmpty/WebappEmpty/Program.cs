var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string mainpage = "mainpage";
app.MapGet("/", () => mainpage);
app.MapGet("/Home",()=>"�ݰ����ϴ� <b>Home<b> �Դϴ�");
app.MapGet("/About", () => "About page");

app.Run();
