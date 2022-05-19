using ProjectBank.Aplication.Models.Bank;
using ProjectBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Aplication.Interfaces
{
    public interface IOperationCommandHandle
    {
        IEnumerable<Tribute> send(List<TicketModel> ticket);
    }
}
