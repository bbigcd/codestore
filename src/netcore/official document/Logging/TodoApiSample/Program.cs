using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TodoApiSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            // var webHost = new WebHostBuilder()
            //     .UseKestrel()
            //     .UseContentRoot(Directory.GetCurrentDirectory())
            //     .ConfigureAppConfiguration((hostingContext, config) =>
            //     {
            //         var env = hostingContext.HostingEnvironment;
            //         config.AddJsonFile("appsetting.json", optional: true, reloadOnChange: true)
            //               .AddJsonFile($"appsetting.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
            //         config.AddEnvironmentVariables();
            //     })
            //     .ConfigureLogging((hostingContext, logging) =>
            //     {
            //         logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
            //         logging.AddConsole();
            //         logging.AddDebug();
            //         logging.AddEventSourceLogger();
            //     })
            //     .UseStartup<Startup>()
            //     .Build();
            // webHost.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                });
    }
}
