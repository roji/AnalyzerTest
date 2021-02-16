using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Core.Tools;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Persistence.Context;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Pomelo.EntityFrameworkCore.MySql.Storage;

namespace Persistence
{
   public static class Extentions
   {
      public static void AddUnitOfWorkServices(this IServiceCollection services, string connectionString, IWebHostEnvironment env)
      {
         // services.AddEntityFrameworkMySql();
         services.AddDbContextPool<AppDbContext>((serviceProvider, options) =>
         {
            if (!env.IsProduction())
               options.EnableSensitiveDataLogging();

            options.UseLazyLoadingProxies();
            /*
            options.UseMySql(connectionString,
               mysqlOptions =>
               {
                  mysqlOptions.CharSet(CharSet.Utf8Mb4);
                  mysqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend);
               });
               */
         });

         services.AddScoped<IDbInitializer, DbInitializer>();
      }

   }
}
