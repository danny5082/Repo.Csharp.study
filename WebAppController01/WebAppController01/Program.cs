var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
//app.MapDefaultControllerRoute();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}"
    //pattern: "{controller=First}/{action=first}/{id?}"
    pattern: "{controller=Home}/{action=About}/{id?}"
);
app.Run();
