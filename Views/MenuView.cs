using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLinQ.Views
{
    public static class MenuView
    {
        public static void MainMenu()
        {
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
                        ProductView.ListProducts();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        ProductView.ListEndProducts();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        ProductView.ListProductsMustBuy();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        InvoiceView.ReceiptsJanuary();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        InvoiceDetailView.GetProductsFromReceipt();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        ProductView.CalculateTotalPriceStock();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Gracias por usar nuestro Servicio");
                        bandera = true;
                        break;
                    default:
                        Console.WriteLine("No haz seleccionado ninguna de las opciones.");
                        Console.WriteLine($"Vemos mi so:)");
                        bandera = true;
                        break;
                }
            }
        }

    }
}
