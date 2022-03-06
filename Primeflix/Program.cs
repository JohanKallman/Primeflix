using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Primeflix.Data;
using Primeflix.Models;
using System;
using System.Net.WebSockets;

namespace Primeflix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hej hej");
            Console.WriteLine("jaaajaaajaa");
            var host = CreateHostBuilder(args).Build();
            Console.WriteLine("jesus");
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
