using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace NutritionControl
{
    /// <summary>
    /// Entry point class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point for a project
        /// </summary>
        /// <param name="args">Arguments for program</param>
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}