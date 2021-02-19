using CompanyStatistics.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CompanyStatistics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = CreateHostBuilder(args)
                .Build()
                .MigrateDatabase();

            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var hostingEnvironment = services.GetService<IWebHostEnvironment>();

                if (hostingEnvironment.IsDevelopment())
                {
                    webHost.SetupDevelopmentDatabase();
                }
            }

            webHost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
