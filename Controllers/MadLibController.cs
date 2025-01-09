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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        } 

        [HttpGet]
        [Route("MadLib/{victimName}/{taskName}/{rivalName}/{animalCount}/{animalDescription}/{animal}/{item}/{specialMoveName}/{rangeNumber}/{unitOfDistance}")]

        public string MadLib(string victimName, string taskName, string rivalName, string animalCount, string animalDescription, string animal, string item, string specialMoveName, string rangeNumber, string unitOfDistance)
        {
            return _madLibServices.MadLib(victimName, taskName, rivalName, animalCount, animalDescription, animal, item, specialMoveName, rangeNumber, unitOfDistance);
        }
    }
}