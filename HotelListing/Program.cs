using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(path: "c:\\hotellistings\\logs\\log-.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                rollingInterval: RollingInterval.Day,
                restrictedToMinimumLevel: LogEventLevel.Information
                ).CreateLogger();
            try
            {
                Log.Information("Applocation is starting");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Appliocation stopped");
            }
            finally
            {
                Log.CloseAndFlush();
            }

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseSerilog() 
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}