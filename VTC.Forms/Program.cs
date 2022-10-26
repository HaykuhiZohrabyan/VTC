using VTC.Data;
using VTC.Application.Services.Interfaces;
using VTC.Data.Repositories.Interfaces;
using VTC.Data.Repositories;
using VTC.Application.Services;
using Microsoft.EntityFrameworkCore;

namespace VTC.Forms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<VTCDataContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("VTCConnectionstring")));
            builder.Services.AddScoped<IFormService, FormService>();
            builder.Services.AddScoped<IFormRepository, FormRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


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
        }
    }
}