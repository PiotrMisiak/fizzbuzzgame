using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class FizzBuzz
    {
        public string GameRules(int number)
        {          
              
                if (number % 3 == 0 && number % 5 == 0)
               
                    return "FizzBuzz";
                
                if (number % 5 == 0)
                
                    return "Buzz";

                if (number % 3 == 0)

                return "Fizz";

                else
                
                return number.ToString();
                
            
        }
        
       
    }
}
