using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ConsoleTables;

namespace PracticaLinQ.Models
{
    public class Data
    {
        // public List<Product> Products { get; set; }
        // public List<Customer> Customers { get; set; }
        // public List<Invoice> Invoices { get; set; }
        // public List<InvoiceDetail> InvoiceDetails { get; set; }
        // public Data(string jsonFilePath)
        // {
        //     // Cargar datos desde el archivo JSON al constructor del repositorio
        //     string jsonData = File.ReadAllText("./Data/Products.json");
        //     // Console.WriteLine(jsonData);
        //     // data = JsonSerializer.Deserialize<Data>(jsonData);
        //     var jsonDocument = JsonDocument.Parse(jsonData);
        //     var productsElement = jsonDocument.RootElement.GetProperty("Products");
        //     Product = JsonSerializer.Deserialize<List<Product>>(productsElement);
        //     foreach (var item in Products)
        //     {
        //         Console.WriteLine(item.Id);
        //     }
        // }
        public Data()
        {

        }

        // public List<T> ObtenerLista<T>(string entidad, Func<T, bool> filtro = null)
        // {

        //     switch (entidad.ToLower())
        //     {
        //         case "products":
        //             return filtro != null ? Products.OfType<T>().Where(filtro).ToList() : Products.OfType<T>().ToList();
        //         case "customers":
        //             return filtro != null ? Customers.OfType<T>().Where(filtro).ToList() : Customers.OfType<T>().ToList();
        //         case "invoices":
        //             return filtro != null ? Invoices.OfType<T>().Where(filtro).ToList() : Invoices.OfType<T>().ToList();
        //         case "invoicedetails":
        //             return filtro != null ? InvoiceDetails.OfType<T>().Where(filtro).ToList() : InvoiceDetails.OfType<T>().ToList();
        //         default:
        //             throw new ArgumentException("Entidad no válida");
        //     }
        // }


        List<Product> Products = new List<Product>
            {
                new Product { Id = 1, Name = "Tornillos", Cantity = 40, UnitPrice = 500, MinStock = 40, MaxStock = 300 },
                new Product { Id = 2, Name = "Clavos", Cantity = 90, UnitPrice = 500, MinStock = 60, MaxStock = 400 },
                new Product { Id = 3, Name = "Bisagras", Cantity = 30, UnitPrice = 1000, MinStock = 50, MaxStock = 450 },
                new Product { Id = 4, Name = "Cadenas", Cantity = 20, UnitPrice = 2000, MinStock = 25, MaxStock = 250 },
                new Product { Id = 5, Name = "Cables", Cantity = 100, UnitPrice = 300, MinStock = 70, MaxStock = 500 },
                new Product { Id = 6, Name = "Tuerca", Cantity = 60, UnitPrice = 200, MinStock = 30, MaxStock = 300 },
                new Product { Id = 7, Name = "Pernos", Cantity = 80, UnitPrice = 400, MinStock = 40, MaxStock = 350 },
                new Product { Id = 8, Name = "Martillo", Cantity = 35, UnitPrice = 1000, MinStock = 20, MaxStock = 150 },
                new Product { Id = 9, Name = "Destornillador", Cantity = 70, UnitPrice = 600, MinStock = 50, MaxStock = 200 },
                new Product { Id = 10, Name = "Llaves", Cantity = 45, UnitPrice = 800, MinStock = 40, MaxStock = 180 }
            };

        List<Invoice> Invoices = new List<Invoice>
            {
                new Invoice { NumReceipt = 123, Date = new DateOnly(2022, 03, 29), ClientId = 1, TotalReceipt = 50000 },
                new Invoice { NumReceipt = 234, Date = new DateOnly(2023, 01, 13), ClientId = 2, TotalReceipt = 100000 },
                new Invoice { NumReceipt = 345, Date = new DateOnly(2016, 12, 13), ClientId = 2, TotalReceipt = 10000 },
                new Invoice { NumReceipt = 456, Date = new DateOnly(2023, 01, 22), ClientId = 3, TotalReceipt = 30000 },
                new Invoice { NumReceipt = 567, Date = new DateOnly(2025, 10, 13), ClientId = 4, TotalReceipt = 5000 },
                new Invoice { NumReceipt = 568, Date = new DateOnly(2023, 01, 30), ClientId = 5, TotalReceipt = 8000 },
                new Invoice { NumReceipt = 569, Date = new DateOnly(2014, 05, 13), ClientId = 6, TotalReceipt = 7500 },
                new Invoice { NumReceipt = 570, Date = new DateOnly(2023, 01, 03), ClientId = 7, TotalReceipt = 12000 }
            };

        List<InvoiceDetail> InvoiceDetails = new List<InvoiceDetail>
            {
                new InvoiceDetail { Id = 1, NumReceipt = 123, ProductId = 1, Cantity = 2 },
                new InvoiceDetail { Id = 2, NumReceipt = 123, ProductId = 2, Cantity = 3 },
                new InvoiceDetail { Id = 3, NumReceipt = 123, ProductId = 3, Cantity = 1 },
                new InvoiceDetail { Id = 4, NumReceipt = 123, ProductId = 4, Cantity = 4 },
                new InvoiceDetail { Id = 5, NumReceipt = 234, ProductId = 1, Cantity = 3 },
                new InvoiceDetail { Id = 6, NumReceipt = 234, ProductId = 2, Cantity = 5 },
                new InvoiceDetail { Id = 7, NumReceipt = 345, ProductId = 3, Cantity = 2 },
                new InvoiceDetail { Id = 8, NumReceipt = 456, ProductId = 4, Cantity = 3 },
                new InvoiceDetail { Id = 9, NumReceipt = 456, ProductId = 5, Cantity = 6 },
                new InvoiceDetail { Id = 10, NumReceipt = 567, ProductId = 1, Cantity = 4 }
            };


        public void ListProducts()
        {
            var table = new ConsoleTable("Name", "Id", "Quantity", "UnitPrice");
            foreach (var x in Products)
            {
                table.AddRow(x.Name, x.Id, x.Cantity, x.UnitPrice);
            }
            table.Write();
        }

        public void ListEndProducts()
        {
            var FinalProduct = (from j in Products where j.Cantity < j.MinStock select j).ToList();
            Console.WriteLine($"The Products that are close to Be Finished are:");
            var table = new ConsoleTable("Name", "Quantity", "MinStock");
            foreach (var J in FinalProduct)
            {
                table.AddRow(J.Name, J.Cantity, J.MinStock);
            }
            table.Write();
        }

        public void ListProductsMustBuy()
        {
            var ProductsToBuy = (from p in Products where p.Cantity < p.MinStock select p).ToList();
            ProductsToBuy.ForEach(P => Console.WriteLine($"The {P.Name} are close to Be Finished (there are only {P.Cantity}), you should {P.MaxStock - P.Cantity} to reach the maximun stock\n-----------------------------------------------------------------------------------------------------"));
        }

        public void ReceiptsJanuary()
        {
            var ReceiptsJan = (from d in Invoices where d.Date.Month == 01 && d.Date.Year == 2023 select d).ToList();
            var table = new ConsoleTable("", "Number", "Total", "Date");
            foreach (var item in ReceiptsJan)
            {
                table.AddRow((ReceiptsJan.IndexOf(item) + 1), item.NumReceipt, item.TotalReceipt, item.Date);
            }
            table.Write();
        }

        public void GetProductsFromReceipt()
        {
            Console.WriteLine("Put the number of the invoice: ");
            int number = Convert.ToInt32(Console.ReadLine());
            var table = new ConsoleTable("ProductId", "Quantity", "Name", "UnitPrice", "Total");
            var list = (from q in InvoiceDetails
                        join w in Invoices
                        on q.NumReceipt equals w.NumReceipt
                        join e in Products on q.ProductId equals e.Id
                        where w.NumReceipt == number
                        select new
                        {
                            ProductId = q.ProductId,
                            Cantity = q.Cantity,
                            Name = e.Name,
                            UnitPrice = e.UnitPrice,
                            Total = q.Cantity * e.UnitPrice
                        }).ToList();

            if (InvoiceDetails.Any(x => x.NumReceipt == number))
            {
                Console.Clear();
                Console.WriteLine($"The products of the receipt number {number}");
                foreach (var z in list)
                {
                    table.AddRow(z.ProductId, z.Cantity, z.Name, z.UnitPrice, z.Total);
                }
                table.Write();
            }
            else
            {
                Console.WriteLine($"The receipt number {number} does not exist");
            }
        }

        public void CalculateTotalPriceStock()
        {
            int total = 0;
            var table = new ConsoleTable("Name", "Total");
            foreach (var item in Products)
            {
                table.AddRow(item.Name, item.UnitPrice * item.Cantity);
                total += (item.UnitPrice * item.Cantity);
            }
            table.Write();
            Console.WriteLine($"The total value of the inventory is: {total}");
        }
    }
}