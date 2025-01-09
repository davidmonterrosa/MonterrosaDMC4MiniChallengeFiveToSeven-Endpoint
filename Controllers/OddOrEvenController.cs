using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MonterrosaDMC4MiniChallengeFiveToSeven_Endpoint.Services;

namespace MonterrosaDMC4MiniChallengeFiveToSeven_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven/{numberToCheck}")]

        public string OddOrEven(string numberToCheck)
        {
            return _oddOrEvenServices.OddOrEven(numberToCheck);
        }

    }
}