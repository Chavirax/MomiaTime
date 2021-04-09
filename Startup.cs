using Advanced.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Momias.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Momias
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<DataContext>(opts => {
                opts.UseSqlServer(Configuration[
                "ConnectionStrings:PeopleConnection"]);
                opts.EnableSensitiveDataLogging(true);
            });
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            
            //Identity stuffy
            services.AddDbContext<IdentityContext>(opts =>
             opts.UseSqlServer(Configuration[
                "ConnectionStrings:IdentityConnection"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<IdentityContext>();

            //password identification and specifics such as length
            services.Configure<IdentityOptions>(opts => {
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                //requires the user to enter a valid email address
                opts.User.RequireUniqueEmail = true;
                //the letters that are allowed to be used by the user to create a username
                opts.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyz";


                opts.Password.RequireDigit = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, DataContext context)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute("controllers",
                    "controllers/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });
            SeedData.SeedDatabase(context);
            IdentitySeedData.CreateAdminAccount(app.ApplicationServices, Configuration);
        }
    }
}
