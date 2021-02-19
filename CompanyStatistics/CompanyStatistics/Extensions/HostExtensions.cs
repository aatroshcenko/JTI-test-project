using CompanyStatistics.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyStatistics.Extensions
{
    public static class HostExtensions
    {
        public static IHost MigrateDatabase(this IHost webHost)
        {
            using(var scope = webHost.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                using(var context = serviceProvider.GetRequiredService<CompanyDbContext>())
                {
                    try
                    {
                        context.Database.Migrate();
                    }
                    catch(Exception e)
                    {
                        var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                        logger.LogError(e, "Datebase migration is failed.");

                        throw;
                    }
                }
            }

            return webHost;
        }

        public static IHost SetupDevelopmentDatabase(this IHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                using (var context = services.GetRequiredService<CompanyDbContext>())
                {
                    try
                    {
                        context.Database.EnsureCreated();
                        context.SeedDatabase();
                    }
                    catch (Exception ex)
                    {
                        var logger = services.GetRequiredService<ILogger<Program>>();
                        logger.LogError(ex, "An error occurred while setting up or seeding the development database.");
                    }
                }
            }

            return webHost;
        }
    }
}
