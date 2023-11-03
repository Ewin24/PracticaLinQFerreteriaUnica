using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLinQ.Models
{
    public class InvoiceDetail : BaseModel
    {
        public int Id { get; set; }
        public int NumReceipt { get; set; }
        public int ProductId { get; set; }
        public int Cantity { get; set; }
        public int Price { get; set; }
    }
}