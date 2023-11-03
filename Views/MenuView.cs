using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticaLinQ.Models;

namespace PracticaLinQ.Views
{
    public static class MenuView
    {
        public static void MainMenu()
        {
            Data funciones = new();
            bool bandera = false;

            while (bandera == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║       Steel Hardware Store         ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                Console.WriteLine("║  1. List Inventory Products        ║");
                Console.WriteLine("║  2. List Products To Be Finished   ║");
                Console.WriteLine("║  3. List Products You Should Buy   ║");
                Console.WriteLine("║  4. List Receipts January/2023     ║");
                Console.WriteLine("║  5. List Products From A Receipt   ║");
                Console.WriteLine("║  6. Calculate The Total Inventory  ║");
                Console.WriteLine("║  7. Exit                           ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.WriteLine($"Elige una opción: ");
                var opcion = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        funciones.ListProducts();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        funciones.ListEndProducts();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        funciones.ListProductsMustBuy();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        funciones.ReceiptsJanuary();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        funciones.GetProductsFromReceipt();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        funciones.CalculateTotalPriceStock();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Thanks for using our service");
                        bandera = true;
                        break;
                    default:
                        Console.WriteLine("You haven't choose any of the options.");
                        Console.WriteLine($"Vemos mi so:)");
                        bandera = true;
                        break;
                }
            }
        }

    }
}
