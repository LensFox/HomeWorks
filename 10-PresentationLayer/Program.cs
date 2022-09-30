using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using NetEscapades.Extensions.Logging.RollingFile;
using Microsoft.Extensions.Logging;

namespace _10_ThreeLayerProject.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureLogging((context,builder) =>
            {
                builder.AddFile();
            })
            .ConfigureAppConfiguration(config =>
            {
                config.AddJsonFile("myappsettings.json", optional: true, reloadOnChange: true);
            })
            .UseStartup<Startup>();


    }
}
