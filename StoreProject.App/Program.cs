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
app.UseRouting();

    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
