using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace ConfigurationFileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configurationRoot = builder.Build();

            // IChangeToken token = configurationRoot.GetReloadToken();

            // 调试修改debug中的文件，修改同级目录下的 appsettings.json 无效
            ChangeToken.OnChange(() => configurationRoot.GetReloadToken(), () =>
            {
                Console.WriteLine($"Key1:{configurationRoot["Key1"]}");
                Console.WriteLine($"Key2:{configurationRoot["Key2"]}");
                Console.WriteLine($"Key3:{configurationRoot["Key3"]}");
            });
            Console.WriteLine("开始了");

            Console.ReadKey();
        }
    }
}
