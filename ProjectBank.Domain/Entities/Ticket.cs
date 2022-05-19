using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Domain.Entities
{
    public class Ticket
    {
        public operationTypeModel operation { get; set; }
        public decimal unitCost { get; set; }
        public int quantity { get; set; }
    }
}
