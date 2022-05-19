using Microsoft.AspNetCore.Mvc;
using ProjectBank.Aplication.Interfaces;
using ProjectBank.Aplication.Models.Bank;
using ProjectBank.Domain.Entities;
using System.Collections.Generic;

namespace ProjectBank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicesController : ControllerBase
    {
        private readonly IOperationCommandHandle _operationCommandHandle;

        public ServicesController(IOperationCommandHandle operationCommandHandle)
        {
            this._operationCommandHandle = operationCommandHandle;
        }

        [HttpGet]
        [Route("/get")]
        public bool Get()
        {
            return true;
        }


        [HttpPost]
        [Route("/tickets")]
        public IEnumerable<Tribute> Post([FromBody] List<TicketModel> tickets)
        {
                return _operationCommandHandle.send(tickets);
        }
    }
}
