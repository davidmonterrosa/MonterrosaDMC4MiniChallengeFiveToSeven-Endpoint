using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC4MiniChallengeFiveToSeven_Endpoint.Services
{
    public class ReverseItNumbersServices
    {
        public string ReverseItNumbers(string number)
        {
            int integerNumber;
            string result = "";
            bool isInteger = int.TryParse(number, out integerNumber);
            if(isInteger == true) {
                if (integerNumber < 0){
                    integerNumber *= -1;
                    for(int i = number.Length - 1; i > 0; i--){
                        result += integerNumber % 10;
                        integerNumber /= 10;
                    }
                    return $"{result}-";            
                } else{
                    for(int i = number.Length - 1; i >= 0; i--){
                        result += integerNumber % 10;
                        integerNumber /= 10;
                    }
                    return result;
                }
            } else {
                return "Error: Invalid input. Please type an integer number.";
            }
        }
    }
}