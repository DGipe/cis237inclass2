using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine("solve 5!");
            Console.WriteLine("The ansser is: ");
            Console.WriteLine(factorial.CalculateFactorial(31));
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
