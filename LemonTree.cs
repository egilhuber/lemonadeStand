using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class LemonTree
    {
        //member variables
        public int givenLoans = 0;

        //ctor
        public LemonTree()
        {

        }
        //member methods
        
        public int PayBack(int thing)
        {
            givenLoans += thing;
            Console.WriteLine($"You will owe the lemon tree {givenLoans} at the end of the game.");

            return givenLoans;
        }
    }
}
