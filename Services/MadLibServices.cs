using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC4MiniChallengeFiveToSeven_Endpoint.Services
{
    public class MadLibServices
    {
        public string MadLib(string victimName, string taskName, string rivalName, string animalCount, string animalDescription, string animal, string item, string specialMoveName, string rangeNumber, string unitOfDistance)
        {
            return $"{victimName} was in the middle of {taskName} when suddenly their bitter rival, {rivalName}, appeared with {animalCount} {animalDescription} attack {animal}. Luckily you arrived just in time with your trusty {item}. You unleashed your special move— {specialMoveName}, which obliterated all enemies within {rangeNumber} {unitOfDistance}. With {rivalName} defeated, the day has been saved! Now, {victimName} can get back to {taskName} in peace.";
        }
    }
}