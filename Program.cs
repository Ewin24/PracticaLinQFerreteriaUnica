internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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
        }
    }
}