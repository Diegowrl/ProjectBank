using AutoMapper;
using ProjectBank.Aplication.Models.Bank;
using ProjectBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectBank.Aplication.Map
{
    public class TicketMap : Profile
    {
        public TicketMap()
        {
            CreateMap<TicketModel, Ticket>()
                .ForMember(d => d.operation, opt => opt.MapFrom(src => src.operation.Map()));
        }
    }
}
