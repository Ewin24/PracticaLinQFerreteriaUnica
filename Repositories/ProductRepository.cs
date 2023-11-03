using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PracticaLinQ.Interfaces;
using PracticaLinQ.Models;

namespace PracticaLinQ.Repositories
{
    public class ProductRepository : IProductRepository
    {
        Data DataObj;
        private List<Product> Products;

        public List<Product> ObtenerTodos()
        {
            // DataObj = new("");
            // Products = DataObj.ObtenerLista<Product>("products");
            foreach (Product item in Products)
            {
                Console.WriteLine(item.Id);
            }
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