using BusinessLayer.Services;
using DataAccessLayer.Mappers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
builder.Services.AddTransient<ILoginService,LoginService>();
builder.Services.AddTransient<ILoginMapper, LoginMapper>();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.Run();
