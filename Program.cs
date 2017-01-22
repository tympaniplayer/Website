using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Website
{
    public class Program
    {
        public static void Main(string[] args)
{
 
    var host = new WebHostBuilder()
        .UseKestrel()
        .UseUrls("http://localhost:5000")
        .UseContentRoot(Environment.GetEnvironmentVariable("ASPNETCO‌​RE_ENVIRONMENT") == "Production" ? Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) : Directory.GetCurrentDirectory())
        .UseStartup<Startup>()
        .Build();
 
    host.Run();
}
    }
}
