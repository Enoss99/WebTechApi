using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EcoApiEscen {
    public class Program {
        public static void Main(string[] args) { CreateHostBuilder(args).Build().Run(); }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}

namespace courses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int capacity = 5;
            var stock = new StockProduit(new List<Produit>(capacity), new List<int>(capacity));

            Gestion gestion = new Gestion(stock);
            
            gestion.AddProductInStock(
                new Produit("XIAOMI","smarthphone",new Price(250.50F,Currency.Euro)),
                2);
            gestion.AddProductInStock(
                new Produit("MACBOOK AIR","ordinateur",new Price(1050.0F,Currency.Euro)),
                2);
            
            
            Console.WriteLine($"\n List of product");
            gestion.getAllProduit();
            
            Console.WriteLine($"\n Update");
            gestion.UpdateProduct("XIAOMI",5);
            
            gestion.getAllProduit();
            
            Console.WriteLine($"\n Delete");
            gestion.DeleteProduit("XIAOMI");
            
            gestion.getAllProduit();
        }
    }
}