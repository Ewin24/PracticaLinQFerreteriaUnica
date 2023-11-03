using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLinQ.Models
{
    public class InvoiceDetail : BaseModel
    {
        private string NumInvoice { get; set; }
        private int IdProduct { get; set; }
        private Product Product { get; set; }
        private int Quantity { get; set; }
        private float Value { get; set; }
    }
}