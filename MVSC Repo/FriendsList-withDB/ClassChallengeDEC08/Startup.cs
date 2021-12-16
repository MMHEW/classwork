using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassChallengeDEC08.Models;
using ClassChallengeDEC08.Services;
using ClassChallengeDEC08.Data;
using Microsoft.EntityFrameworkCore;


namespace ClassChallengeDEC08
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //holds the connection string to be send in the AddDbContext
            string connectionString = "Server = DESKTOP-8L3F7PM\\SQLEXPRESS; Database = Friends; Trusted_Connection = True; MultipleActiveResultSets = true";

            //says now FriendsList only exsists when requested instead of being there all the time with Singleton
            services.AddTransient<IFriendsList, FriendsList>();

            //adds a service DBContext to use for dependency injectoion
            services.AddDbContext<FriendContext>(options => options.UseSqlServer(connectionString));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
