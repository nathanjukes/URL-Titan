using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using URL_Shortener.DatabaseContexts;
using Microsoft.Extensions.Configuration;
using URL_Shortener.Services;
using Microsoft.AspNetCore.Routing;

namespace URL_Shortener
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();

            //Adding the db context class to scope
            services.AddDbContext<URLContext>(options => options.UseMySQL(_configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<URLService>();

            services.AddSingleton<MailService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
                (
                    name: "default",
                    pattern: "{controller=Url}/{action=Index}/{id?}"
                );
            });
        }
    }
}
