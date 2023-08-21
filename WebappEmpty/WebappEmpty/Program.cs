var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string mainpage = "mainpage";
app.MapGet("/", () => mainpage);
app.MapGet("/Home",()=>"반갑습니다 <b>Home<b> 입니다");
app.MapGet("/About", () => "About page");

app.Run();
