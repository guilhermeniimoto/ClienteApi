using Microsoft.Owin.Hosting;
using System;

namespace ClienteHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(WebApp.Start<Startup>("http://localhost:9999"))
            {
                Console.WriteLine("Serve host rodando!");
                Console.ReadLine();
            }
        }
    }
}
