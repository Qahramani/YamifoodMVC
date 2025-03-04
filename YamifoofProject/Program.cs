using Microsoft.EntityFrameworkCore;
using YamifoofProject.DataAccessLayer.Context;

namespace YamifoofProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}"));
            

            app.Run();
        }
    }
}
