using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace Persistence.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory();
            Console.WriteLine($"Using `{basePath}` as the BasePath");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.EnableSensitiveDataLogging();
            var connectionString = configuration.GetConnectionString("Default");
            /*
            builder.UseMySql(connectionString, mysqlOptions =>
            {
                mysqlOptions.CharSet(CharSet.Utf8Mb4);
                mysqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend);
            });*/
            return new AppDbContext(builder.Options);
        }
    }
}