using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using PracticaLinQ.Interfaces;
using PracticaLinQ.Models;

namespace PracticaLinQ.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> Customers;

        public CustomerRepository(string jsonFilePath)
        {
            // Cargar datos desde el archivo JSON al constructor del repositorio
            string jsonData = File.ReadAllText(jsonFilePath);
            Customers = JsonSerializer.Deserialize<List<Customer>>(jsonData);
        }

        public List<Customer> ObtenerTodos()
        {
            return Customers;
        }

        public Customer ObtenerPorId(int id)
        {
            return Customers.FirstOrDefault(p => p.Id == id);
        }

        public void AgregarEntidad(Customer Customer)
        {
            Customer.Id = Customers.Max(p => p.Id) + 1; // Simulación de generación de ID
            Customers.Add(Customer);
        }

        public void ActualizarEntidad(Customer Customer)
        {
            var TExistente = Customers.FirstOrDefault(p => p.Id == Customer.Id);
            if (TExistente != null)
            {
            }
        }

        public void EliminarEntidad(int id)
        {
            var TExistente = Customers.FirstOrDefault(p => p.Id == id);
            if (TExistente != null)
            {
                Customers.Remove(TExistente);
            }
        }
    }
}