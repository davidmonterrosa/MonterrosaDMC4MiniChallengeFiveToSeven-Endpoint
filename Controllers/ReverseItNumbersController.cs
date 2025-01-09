using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDMC4MiniChallengeFiveToSeven_Endpoint.Services;

namespace MonterrosaDMC4MiniChallengeFiveToSeven_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumbersServices _reverseItNumbersServices;

        public ReverseItNumbersController(ReverseItNumbersServices reverseItNumbersServices)
        {
            _reverseItNumbersServices = reverseItNumbersServices;
        }

        [HttpGet]
        [Route("ReverseItNumbers/{number}")]

        public string ReverseItNumbers(string number)
        {
            return _reverseItNumbersServices.ReverseItNumbers(number);
        }
    }
}