using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaLinQ.Models
{
    public class Invoice : BaseModel
    {

        private DateTime Date { get; set; }
        private int IdCustomer { get; set; }
        private Customer Customer { get; set; }
        private float Total { get; set; }

    }
}