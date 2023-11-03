using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticaLinQ.Models
{
    public class Data
    {
        public List<Product> Products { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }

        private Data data;
        public Data(string jsonFilePath)
        {
            // Cargar datos desde el archivo JSON al constructor del repositorio
            string jsonData = File.ReadAllText("./Data/Storage.json");
            Console.WriteLine(jsonData);
            data = JsonSerializer.Deserialize<Data>(jsonData);
        }

        public List<T> ObtenerLista<T>(string entidad, Func<T, bool> filtro = null)
        {
            switch (entidad.ToLower())
            {
                case "products":
                    return filtro != null ? data.Products.OfType<T>().Where(filtro).ToList() : data.Products.OfType<T>().ToList();
                case "customers":
                    return filtro != null ? data.Customers.OfType<T>().Where(filtro).ToList() : data.Customers.OfType<T>().ToList();
                case "invoices":
                    return filtro != null ? data.Invoices.OfType<T>().Where(filtro).ToList() : data.Invoices.OfType<T>().ToList();
                case "invoicedetails":
                    return filtro != null ? data.InvoiceDetails.OfType<T>().Where(filtro).ToList() : data.InvoiceDetails.OfType<T>().ToList();
                default:
                    throw new ArgumentException("Entidad no válida");
            }
        }

    }
}