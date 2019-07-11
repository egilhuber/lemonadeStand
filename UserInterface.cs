using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        //member variables

        //ctor
        public UserInterface()
        {

        }
        
        //member methods

        public void DisplayRules()
        {
            //display plot/purpose/whatever of game (sell lemonade, make profit)
            //display controls (like ability to use "quit" keyword at any time, "store" between days, etc 
            //have a "press enter to continue" that clears the screen 

            Console.WriteLine("game rules and controls go here. press enter to clear screen");
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayInventory(double itemOne, double itemTwo, double itemThree, double itemFour)
        {
            //displays sugar, lemon, etc objects from inventory
            Console.WriteLine($"You have {itemOne} sugar.");
            Console.WriteLine($"You have {itemTwo} lemons.");
            Console.WriteLine($"You have {itemThree} cups.");
            Console.WriteLine($"You have {itemFour} ice cubes.");
            
        }
        
        public void DisplayCashBalance(double balance)
        {
            //displays cash balance variable from player
            Console.WriteLine($"You have {balance} cents.");
        }

        public void DisplayForecast()
        {
            //displays forecast from weather
        }

        public void DisplayEndOfDayStats()
        {
            //displays end of day stats from day
        }

        public void DisplayEndOfGameStats()
        {
            //displays end of game stats 
            //these should just be the final reading from the end of day stats 
            //in day but like im not there yet so we'll find out 
        }

        //last line of big block
    }
}
