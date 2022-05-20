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
        public Tribute tribute { get; set; }

        public void calculateTax()
        {
            if (operation == operationTypeModel.buy)
                tribute.tax = 0;
            else if(validateTotalValor())
            {
                tribute.tax = 0;
            }
            else
            {

            }
        }

        public bool validateTotalValor()
        {
            return quantity * unitCost <= 20000 ? true : false;
        }
    }
}
