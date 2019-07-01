using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ConfigurationSample.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ConfigurationSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static Dictionary<string, string> arrayDic = new Dictionary<string, string>
        {
            {"array:entries:0", "value0"},
            {"array:entries:1", "value1"},
            {"array:entries:2", "value2"},
            {"array:entries:4", "value4"},
            {"array:entries:5", "value5"}
        };

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Config"));// 设置配置文件的默认路径 当前程序目录下的Config文件夹
                    config.AddInMemoryCollection(arrayDic);
                    config.AddJsonFile("missing_value.json", optional: false, reloadOnChange: false);
                    config.AddJsonFile("json_array.json", optional: false, reloadOnChange: true);
                    config.AddJsonFile("starship.json", optional: false, reloadOnChange: false);
                    config.AddXmlFile("tvshow.xml", optional: false, reloadOnChange: false);
                    config.AddEFConfiguration(options => options.UseInMemoryDatabase("InMemoryDb"));
                })
                .UseStartup<Startup>();
    }
}
