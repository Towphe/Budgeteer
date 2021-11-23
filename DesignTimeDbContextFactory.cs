using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Budgeteer.Identity;

namespace Budgeteer
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppUserDbContext>
    {
        public IConfiguration Configuration { get; set; }
        public DesignTimeDbContextFactory(IConfiguration config) => Configuration = config;
        public AppUserDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AppUserDbContext>();

            builder.UseNpgsql(Configuration["AppUserDB:Key"]);
            return new AppUserDbContext(builder.Options);
        }
    }
}
