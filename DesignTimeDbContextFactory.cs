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
        public AppUserDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AppUserDbContext>();

            // TODO: Place connection string on user-secrets
            builder.UseNpgsql("Host=localhost;Database=budgeteer_appuserdb;Username=postgres;Password=pingu");
            return new AppUserDbContext(builder.Options);
        }
    }
}
