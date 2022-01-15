using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Budgeteer.Identity;
using Budgeteer.Models;

namespace Budgeteer
{
    public class Startup
    {
        public Startup(IConfiguration config) => Configuration = config;
        public IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPasswordHasher<AppUser>, PasswordHasher>();
            services.AddDbContext<budgeteer_appdbContext>(opts =>
            {
                opts.UseNpgsql(Configuration["AppDB:Key"]);
            });
            services.AddDbContext<AppUserDbContext>(opts =>
            {
                opts.UseNpgsql(Configuration["AppUserDB:Key"]);
            });
            services.AddIdentityCore<AppUser>(opts =>
            {
                // TODO: Make these strict
                opts.Password.RequireUppercase = false;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppUserDbContext>().AddSignInManager().AddDefaultTokenProviders();
            services.AddAuthentication(opts => opts.DefaultScheme = IdentityConstants.ApplicationScheme).AddCookie(IdentityConstants.ApplicationScheme, opts =>
            {
                opts.LoginPath = "/account/signin";
                opts.LogoutPath = "/account/signout";
                opts.ReturnUrlParameter = "returnUrl";
            });
            services.AddAuthorization();
            services.AddControllers();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                endpoints.MapFallbackToPage("/404");
            });
        }
    }
}
