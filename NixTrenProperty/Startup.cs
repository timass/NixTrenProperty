using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnionApp.Domain.Core;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using NixTrenProperty.Models;
using NixTrenProperty.ViewModels;
using Microsoft.AspNetCore.Http;

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
            // добавление ApplicationDbContext для взаимодействия с базой данных учетных записей
            
            // добавление сервисов Idenity
            services.AddIdentity<User, IdentityRole>(opts => {
                opts.User.RequireUniqueEmail = false;    // уникальный email
                opts.User.AllowedUserNameCharacters = ".@abcdefghijklmnopqrstuvwxyz"; // допустимые символы
                opts.Password.RequiredLength = 6;   // минимальная длина
                opts.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                opts.Password.RequireLowercase = true; // требуются ли символы в нижнем регистре
                opts.Password.RequireUppercase = true; // требуются ли символы в верхнем регистре
                opts.Password.RequireDigit = true; // требуются ли цифры
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
                    //    name: "userArea",
                    //    areaName: "userArea",
                    //    pattern: "UserArea/{controller=Home}/{action=Index}/{id?}");                   
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                   // endpoints.MapRazorPages();
                });
            
        }
    }
}
