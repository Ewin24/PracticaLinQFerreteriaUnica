using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLinQ.Models
{
    public class Product : BaseModel
    {
        private string Name { get; set; }
        private float Price { get; set; }
        private int Quantity { get; set; }
        private int StockMin { get; set; }
        private int StockMax { get; set; }
    }
}