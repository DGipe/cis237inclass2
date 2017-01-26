using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {
        public int CalculateFactorial(int number)
        {
            //This is the base case
            //if the number is one, just return it.
            if (number ==1)
            {
                return 1;
            }
            //NOt the base case, so make a recursive call
            //to ourself.
            return number * CalculateFactorial(number - 1);


        }
    }
}
