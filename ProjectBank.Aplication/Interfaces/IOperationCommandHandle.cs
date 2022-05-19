using ProjectBank.Aplication.Models.Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Aplication.Interfaces
{
    public interface IOperationCommandHandle
    {
        bool send(TicketModel ticket);
    }
}
