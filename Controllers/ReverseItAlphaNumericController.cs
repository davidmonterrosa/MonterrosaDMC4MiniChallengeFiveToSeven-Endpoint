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
    public class ReverseItAlphaNumericController : ControllerBase
    {
        private readonly ReverseItAlphaNumericServices _reverseItAlphaNumericServices;

        public ReverseItAlphaNumericController(ReverseItAlphaNumericServices reverseItAlphaNumericServices)
        {
            _reverseItAlphaNumericServices = reverseItAlphaNumericServices;
        }

        [HttpGet]
        [Route("ReverseItAlphaNumeric/{inputString}")]
        public string ReverseItAlphaNumeric(string inputString)
        {
            return _reverseItAlphaNumericServices.ReverseItAlphaNumeric(inputString);
        }
    }
}