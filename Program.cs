using Microsoft.EntityFrameworkCore;
using MVC_EX_1.Data;

namespace MVC_EX_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(
               (options) =>
               {
                   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
               }
               );
            var app = builder.Build();



            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(
            (endpoints) =>
            {
                endpoints.MapControllerRoute(
                name: "Default",
                pattern: "{Controller=Home}/{Action=Index}/{id:int?}"
                   );
            }
            );
            app.Run();
        }
    }
}
