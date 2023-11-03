using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using PracticaLinQ.Interfaces;
using PracticaLinQ.Models;

namespace PracticaLinQ.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> Products;

        public ProductRepository(string jsonFilePath)
        {
            // Cargar datos desde el archivo JSON al constructor del repositorio
            string jsonData = File.ReadAllText(jsonFilePath);
            Products = JsonSerializer.Deserialize<List<Product>>(jsonData);
        }

        public List<Product> ObtenerTodos()
        {
            return Products;
        }

        public Product ObtenerPorId(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public void AgregarEntidad(Product Product)
        {
            Product.Id = Products.Max(p => p.Id) + 1; // Simulación de generación de ID
            Products.Add(Product);
        }

        public void ActualizarEntidad(Product Product)
        {
            var TExistente = Products.FirstOrDefault(p => p.Id == Product.Id);
            if (TExistente != null)
            {
            }
            //Todo: revision de la diferencia del objeto y la lista
        }

        public void EliminarEntidad(int id)
        {
            var TExistente = Products.FirstOrDefault(p => p.Id == id);
            if (TExistente != null)
            {
                Products.Remove(TExistente);
            }
        }
    }
}