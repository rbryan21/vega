using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace WebApplicationBasic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                // Use Kestrel
                .UseKestrel()
                // Specifying root of application
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                // Specifying the startup class
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
