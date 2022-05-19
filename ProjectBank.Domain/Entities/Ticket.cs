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
        public int capitalGain { get; set; }
        public Tribute tribute { get; set; }

        public void calculateCapitalGain()
        {
            throw new NotImplementedException();
        }
    }
}
