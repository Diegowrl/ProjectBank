using Microsoft.AspNetCore.Mvc;
using ProjectBank.Aplication.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBank.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        public bool Post(UserModel user)
        {
            var rng = new Random();

            return true;
        }

        [HttpGet]
        public bool Get(string UserId)
        {
            var rng = new Random();

            return true;
        }
    }
}
