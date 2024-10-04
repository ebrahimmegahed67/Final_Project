using Final_Project.@interface;
using Final_Project.Models;
using Final_Project.repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using static System.Object;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IProductRepo, productRepo>();
builder.Services.AddScoped<ICategoriesRepo, categoriesRepo>();
builder.Services.AddScoped<IOrderRepo, orderRepo>();
builder.Services.AddScoped<ICustomerRepo, customerRepo>();
builder.Services.AddDbContext<FinalProjectContext>(OptionsBuilder =>
{
    OptionsBuilder.UseSqlServer("Server=.;Database=final_project;Trusted_Connection=True;TrustServerCertificate=True;");

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
