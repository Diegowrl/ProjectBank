using AutoMapper;
using ProjectBank.Aplication.Interfaces;
using ProjectBank.Aplication.Models.Bank;
using ProjectBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Aplication.Commands.Services.Deposit
{
    public class OperationCommandHandle : IOperationCommandHandle
    {
        private readonly IMapper mapper;

        public OperationCommandHandle(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public bool send(TicketModel ticketModel)
        {
            var ticket = mapper.Map<Ticket>(ticketModel);


            if (ticket.quantity > 0)
                return true;

            return false;

        }
    }
}
