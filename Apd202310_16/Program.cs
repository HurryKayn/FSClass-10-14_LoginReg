using DataLibrary.SeedData;
using Microsoft.EntityFrameworkCore;
using DataIdentity.IdentityData;
using Microsoft.AspNetCore.Identity;

namespace Apd202310_14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //--  Richiama metodo per caricamneto dati
            //SeedDataApp.Run();

            //return;
            var builder = WebApplication.CreateBuilder(args);
            //*** Righe aggiunta per gestione Identity Framework
            var connectionString = builder.Configuration.GetConnectionString("SqlServerIdentityConnection");
            builder.Services.AddDbContext<IdentityDb>(options => options.UseSqlServer(connectionString));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<IdentityDb>()
                .AddDefaultTokenProviders();

            //**********************************************************************************************************************************
            // Add services to the container.
            builder.Services.AddControllersWithViews();

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