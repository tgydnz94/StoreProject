using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using StoreProject.Dal.Abstract;
using StoreProject.Dal.Concrete;
using StoreProject.Dal.Context;
using StoreProject.Services.Abstract;
using StoreProject.Services.Concrete;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.UseHttpsRedirection();


app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name:"Admin",
        areaName:"Admin",
        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
        );
    endpoints.MapControllerRoute(

                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
        );
});



app.Run();
