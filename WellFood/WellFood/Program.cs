using Microsoft.EntityFrameworkCore;
using WellFood.BL.Services.Abstractions;
using WellFood.BL.Services.Concretes;
using WellFood.DAL.Contexts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string? connectionStr = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<WellFoodDBContext>(opt =>
{
    opt.UseSqlServer(connectionStr);
});
builder.Services.AddScoped<ISliderItemService,SliderItemService>();
var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
