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
                new Produit("Souris_Razer","souris",new Price(10.00F,Currency.Euro)),
                2);
            gestion.AddProductInStock(
                new Produit("Minitel","ordinateur",new Price(999.00F,Currency.Euro)),
                2);
            
            
            Console.WriteLine($"\n List des produits");
            gestion.getAllProduit();
            
            Console.WriteLine($"\n Mettre à jour");
            gestion.UpdateProduct("Souris_Razer",5);
            
            gestion.getAllProduit();
            
            Console.WriteLine($"\n Supprimer");
            gestion.DeleteProduit("Souris_Razer");
            
            gestion.getAllProduit();
        }
    }
}