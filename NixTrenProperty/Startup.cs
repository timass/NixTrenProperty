using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NixTrenProperty.ViewModels;
using OnionApp.Domain.Core;
using OnionApp.Infrastructure.Data;

namespace NixTrenProperty
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }
        public IConfiguration AppConfiguration { get; set; }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");          
           

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IUserValidator<User>, CustomUserValidator>();
           
            
            // Identity
            services.AddIdentity<User, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = false;    // Email
                opts.User.AllowedUserNameCharacters = ".@abcdefghijklmnopqrstuvwxyz"; // possible symbols
                opts.Password.RequiredLength = 6;   // min length
                opts.Password.RequireNonAlphanumeric = false;   
                opts.Password.RequireLowercase = true; 
                opts.Password.RequireUppercase = true;
                opts.Password.RequireDigit = true; 
            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>();
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
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
                {
                    //endpoints.MapAreaControllerRoute(
                    //   name: "UserArea",
                    //   areaName: "UserArea",
                    //   pattern: "userArea/{controller=User}/{action=Index}/{id?}");
                    //endpoints.MapAreaControllerRoute(
                    //   name: "SellerArea",
                    //   areaName: "SellerArea",
                    //   pattern: "SellerArea/{controller=Seller}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                   // endpoints.MapRazorPages();
                });
            
        }
    }
}
