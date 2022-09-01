using Microsoft.EntityFrameworkCore;
using SolarLab_Test_Prj.Repository;
using SolarLab_Test_Prj.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DBService>(options => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SolarLabTest;Trusted_Connection=True;MultipleActiveResultSets=true"));
builder.Services.AddTransient<IPerson, PersonRepository>();

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
