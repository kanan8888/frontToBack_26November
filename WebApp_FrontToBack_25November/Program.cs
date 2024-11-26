using Microsoft.EntityFrameworkCore;
using WebApp_FrontToBack_25November.DAL;

namespace WebApp_FrontToBack_25November
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(opt=>
            opt.UseSqlServer("server=LAPTOP-769FD5C5;database=AB107_FrontToBack;trusted_connection=true;Encrypt=false")
            );

            var app = builder.Build();

            app.MapControllerRoute(
                name:"defoult",
                pattern:"{controller=Home}/{action=products}"
            );

            app.UseStaticFiles();
            app.Run();
        }
    }
}
