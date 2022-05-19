using Microsoft.AspNetCore.Mvc;
using ProjectBank.Aplication.Interfaces;
using ProjectBank.Aplication.Models.Bank;

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
        [Route("/ticket")]
        public void Post([FromBody] TicketModel ticket)
        {
            var result = _operationCommandHandle.send(ticket);
        }
    }
}
