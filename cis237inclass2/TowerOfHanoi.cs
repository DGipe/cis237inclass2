using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class TowerOfHanoi
    {
        public TowerOfHanoi()
        {
            Console.WriteLine("Enter te number of disks to use.");
            Console.WriteLine("Less than 5 is good");

            string input = Console.ReadLine();
            int diskNumber = Int32.Parse(input);

            //MoveDisc
            moveDisc(diskNumber, 'A', 'B', 'C');
        }


        private void moveDisc(int n, char src, char aux, char dest)
        {
            //If this is true,we have hit the base case.  All printin is done in
            //the base case.
            if (n == 1 )
            {
                Console.WriteLine("Move disc from tower {0} to tower {1}",src, dest);
            }
            else
            {
                //Make a recursuce cal to moce n-1 discs from the source peg
                //to the auz peg
                moveDisc(n - 1, src, dest, aux);

                //Make a recurzice call to move the 1 (bottom) disc from the src
                //to the destination 
                moveDisc(1, src, aux, dest);

                //Make a recirsice call to move n-1 diesc from the aux to the dest               
                moveDisc(n - 1, aux, src, dest);
            }
        }

    }
}
