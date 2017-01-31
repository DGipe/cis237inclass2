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

            Console.WriteLine("Enter 1 for factorial or 2 for Tower of Hanoi");
            string userInput = Console.ReadLine();

            if (userInput == "1")

            {


                Factorial factorial = new Factorial();

                Console.WriteLine("solve 5!");
                Console.WriteLine("The ansser is: ");
                Console.WriteLine(factorial.CalculateFactorial(5));
            }
            else
            {
                //Do tower of Hanoi
                TowerOfHanoi towerOfHanoi = new TowerOfHanoi();
            }
        }
    }
}
