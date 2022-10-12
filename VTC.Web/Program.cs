using VTC.Data;
using Microsoft.EntityFrameworkCore;
using VTC.Application.Services.Interfaces;
using VTC.Application.Services;
namespace VTC.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //var connectionstring = builder.Configuration.GetConnectionString("");
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<VTCDataContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("VTCConnectionstring")));
            builder.Services.AddScoped<IPackageService, PackageService>();
            builder.Services.AddScoped<ILevelService, LevelService>();
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
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}