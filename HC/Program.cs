using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace HC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try { CreateWebHostBuilder(args).Build().Run(); }
            catch (Exception ex)
            {
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\HC.txt", true))
                {
                    file.WriteLine(ex.Message);
                }
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
           
                .UseStartup<Startup>();
    }
}
