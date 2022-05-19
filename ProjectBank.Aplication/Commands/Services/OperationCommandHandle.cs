using AutoMapper;
using ProjectBank.Aplication.Interfaces;
using ProjectBank.Aplication.Models.Bank;
using ProjectBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Tribute> send(List<TicketModel> ticketsModel)
        {
            var tickets = new List<Ticket>();

            foreach (var ticketModel in ticketsModel)
                tickets.Add(mapper.Map<Ticket>(ticketModel));

            foreach (var ticket in tickets)
            {
                ticket.calculateCapitalGain();
            }


            return tickets.Select(x => x.tribute);
        }
    }
}
