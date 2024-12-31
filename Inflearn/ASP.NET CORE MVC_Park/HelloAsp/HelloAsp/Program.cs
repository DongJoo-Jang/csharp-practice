using BusinessLayer.Services;
using DataAccessLayer.Mappers;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
string? connStr = builder.Configuration.GetConnectionString("MSSQL") ?? string.Empty;
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<ILoginMapper, LoginMapper>( provider => new LoginMapper(connStr));

var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.Run();
