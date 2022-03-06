using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mission7._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7._0
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration temp)
        {
            Configuration = temp;
        }

        
       
        // This method gets called by the runtime. Use this method to add services to the container.


        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<BookStoreContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:BookStoreDBConnection"]);
            });
            services.AddScoped<IBookStoreRepository, EFBookStoreRepository>();
            services.AddRazorPages();
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IPurchaseRepository, EFPurchaseRepository>();

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
            //use  wwwroot
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {


                endpoints.MapControllerRoute(
                    name: "typepage",
                   pattern: "{Category}/Page{pageNum}",
                   defaults: new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "paging",
                    pattern: "{controller=Home}/{action=Index}/{pageNum = 1}");
                //pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    "type", "{Category}", new { Controller = "Home", action = "Index", pageNum = 1 });

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();

                
            });


        }
    }
}
