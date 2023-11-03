using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticaLinQ.Models;
using PracticaLinQ.Repositories;

namespace PracticaLinQ.Views
{
    public class ProductView
    {
        public static void ListProducts()
        {
            ProductRepository productRepository = new();
            var products = productRepository.ObtenerTodos();
            Console.WriteLine("sirve");
            foreach (var item in products)
            {
                Console.WriteLine(item.Id);
            }
        }

        public static void ListEndProducts()
        {
            throw new NotImplementedException();
        }

        public static void ListProductsMustBuy()
        {
            throw new NotImplementedException();
        }

        public static void CalculateTotalPriceStock()
        {
            throw new NotImplementedException();
        }
    }
}