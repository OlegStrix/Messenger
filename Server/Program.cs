using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Server
{
    public class Program
    {
        public static MessagesClass ms;
        public static SessionsClass Sessions;

        private static string Url = "http://localhost:5000";
        public static void Main(string[] args)
        {
            ms = new MessagesClass();  
            Sessions = new SessionsClass(); 
            Sessions.LoadFromFile();
            string IP;
            string port;


            if (args.Length > 0)
            {
                IP = args[0];
                port = args[1];
            }
            else
            {
                Console.Write("Enter IP(or press enter or default):");
                IP = Console.ReadLine();
                if (!string.IsNullOrEmpty(IP))
                {
                    Console.Write("Enter port:");
                    port = Console.ReadLine();
                    Url = $"http://{IP}:{port}";
                }
            }

            CreateHostBuilder(args).Build().Run();     
    }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls(Url);
                });
        }
    }
}
