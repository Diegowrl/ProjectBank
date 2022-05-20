using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Domain.Entities
{
    public class Order
    {
        public Order(List<Ticket> ticketsOrder)
        {
            tickets = ticketsOrder;
        }
        public int capitalGain { get; set; }
        public int quantityActual { get; set; }
        public List<Ticket> tickets { get; set; }


        public void calculateCapitalGain()
        {
            throw new NotImplementedException();
        }

        public void calculateQuantityActual(Ticket ticket)
        {
            if (ticket.operation == operationTypeModel.buy)
                quantityActual += ticket.quantity;
            else
                quantityActual -= ticket.quantity;

            if (quantityActual <= 0)
                throw new InvalidOperationException($"quantityActual is less or equal 0");
        }
    }
}
