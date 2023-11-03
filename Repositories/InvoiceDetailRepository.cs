using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using PracticaLinQ.Interfaces;
using PracticaLinQ.Models;

namespace PracticaLinQ.Repositories
{
    public class InvoiceDetailRepository : IInvoiceDetailRepository
    {
        private List<InvoiceDetail> InvoiceDetails;

        public InvoiceDetailRepository(string jsonFilePath)
        {
            // Cargar datos desde el archivo JSON al constructor del repositorio
            string jsonData = File.ReadAllText(jsonFilePath);
            InvoiceDetails = JsonSerializer.Deserialize<List<InvoiceDetail>>(jsonData);
        }

        public List<InvoiceDetail> ObtenerTodos()
        {
            return InvoiceDetails;
        }

        public InvoiceDetail ObtenerPorId(int id)
        {
            return InvoiceDetails.FirstOrDefault(p => p.Id == id);
        }

        public void AgregarEntidad(InvoiceDetail InvoiceDetail)
        {
            InvoiceDetail.Id = InvoiceDetails.Max(p => p.Id) + 1; // Simulación de generación de ID
            InvoiceDetails.Add(InvoiceDetail);
        }

        public void ActualizarEntidad(InvoiceDetail InvoiceDetail)
        {
            var TExistente = InvoiceDetails.FirstOrDefault(p => p.Id == InvoiceDetail.Id);
            if (TExistente != null)
            {
            }
            //Todo: revision de la diferencia del objeto y la lista
        }

        public void EliminarEntidad(int id)
        {
            var TExistente = InvoiceDetails.FirstOrDefault(p => p.Id == id);
            if (TExistente != null)
            {
                InvoiceDetails.Remove(TExistente);
            }
        }
    }
}