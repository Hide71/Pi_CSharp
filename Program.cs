using Pi_CSharp.Data;
using Microsoft.EntityFrameworkCore;
using  Pi_CSharp.Repositorio;

namespace Pi_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //var connectionString = "Server=localhost;Port=3306;Database=Eder_BarberShop;Uid=root;Pwd=root";
            //var serverVersion = new MySqlServerVersion(new Version(8, 0,38));
            builder.Services.AddControllersWithViews();
            //builder.Services.AddDbContext<AppDbContext>(o => o.UseMySql(connectionString, serverVersion));
            var connectionStringMySql = builder.Configuration.GetConnectionString("DataBase"); 
            builder.Services.AddDbContext<AppDbContext>( x => x.UseMySql (connectionStringMySql, Microsoft.EntityFrameworkCore.MySqlServerVersion.Parse("8.0.38")));
            builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            builder.Services.AddScoped<IPlanoRepositorio, PlanoRepositorio>();

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