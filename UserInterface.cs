﻿using System;
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

            Console.WriteLine("██████╗ ██╗   ██╗██╗     ███████╗███████╗   ");
            Console.WriteLine("██╔══██╗██║   ██║██║     ██╔════╝██╔════╝██╗");
            Console.WriteLine("██████╔╝██║   ██║██║     █████╗  ███████╗╚═╝");
            Console.WriteLine("██╔══██╗██║   ██║██║     ██╔══╝  ╚════██║██╗");
            Console.WriteLine("██║  ██║╚██████╔╝███████╗███████╗███████║╚═╝");
            Console.WriteLine("╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚══════╝╚══════╝   ");

            Console.WriteLine("You finally have enough money from investors to fulfill your dreams of opening a lemonade stand. ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("You have 2000 cents. ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("Before your first day begins, you will need to head to the store to purchase some supplies. ");
            Console.WriteLine("Prices at the store change pretty regularly, so keep an eye on them. ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("If you don't have enough funds to purchase the supplies you need, The Lemon Tree bank can help you out. ");
            Console.WriteLine("Be careful, though. You will have to pay back any money you borrow. You won't have to worry about any");
            Console.WriteLine("surprises since debts are included in your running total. ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("Other food stands owners in the area have mentioned that these customers are picky. Their ");
            Console.WriteLine("willingness to spend money depends on factors such as the weather, your recipe, and the price.");
            Console.WriteLine("Luckily, you can check the weather and modify your recipe and price before each business day");
            Console.WriteLine("begins. ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("Additionally, you can opt to run an ad in the local paper to increase your sales. ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("You have 7 days. Good luck!");

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
