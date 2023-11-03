using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using PracticaLinQ.Interfaces;
using PracticaLinQ.Models;

namespace PracticaLinQ.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private List<Invoice> Invoices;

        public InvoiceRepository(string jsonFilePath)
        {
            // Cargar datos desde el archivo JSON al constructor del repositorio
            string jsonData = File.ReadAllText(jsonFilePath);
            Invoices = JsonSerializer.Deserialize<List<Invoice>>(jsonData);
        }

        public List<Invoice> ObtenerTodos()
        {
            return Invoices;
        }

        public Invoice ObtenerPorId(int id)
        {
            return Invoices.FirstOrDefault(p => p.Id == id);
        }

        public void AgregarEntidad(Invoice Invoice)
        {
            Invoice.Id = Invoices.Max(p => p.Id) + 1; // Simulación de generación de ID
            Invoices.Add(Invoice);
        }

        public void ActualizarEntidad(Invoice Invoice)
        {
            var TExistente = Invoices.FirstOrDefault(p => p.Id == Invoice.Id);
            if (TExistente != null)
            {
            }
        }

        public void EliminarEntidad(int id)
        {
            var TExistente = Invoices.FirstOrDefault(p => p.Id == id);
            if (TExistente != null)
            {
                Invoices.Remove(TExistente);
            }
        }
    }
}