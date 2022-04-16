using Microsoft.AspNetCore.Mvc;

namespace ProjectBank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicesController : ControllerBase
    {
        [HttpPost]
        [Route("/Deposit")]
        public string Deposit()
        {
            return "500";
        }

        [HttpPost]
        [Route("/Transfer")]
        public bool Transfer()
        {
            return true;
        }

        [HttpPost]
        [Route("/Withdraw")]
        public string Withdraw()
        {
            return "voce recebeu 100";
        }

        [HttpPost]
        [Route("/Extract")]
        public string Extract()
        {
            return "200";
        }
    }
}
