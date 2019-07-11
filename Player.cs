using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        public double cashBalance;

        public double cupsSugar;
        public double manyLemons;
        public double poundsOfIce;
        public double lemonadeRecipe;
        public int priceOfLemonade;

        public double pitcherSugar;
        public double pitcherLemons;
        public double pitcherIce;

        public double cupsToSell;

        public double potentialProfit;

        public double x = 1;
        //ctor
        public Player()
        {
            cashBalance = 2000;
        }
        //member methods

        public double CreateRecipe()
        {
            Console.WriteLine("How many cups of sugar would you like per pitcher?");
            cupsSugar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many lemons would you like per pitcher?");
            manyLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pounds of ice would you like per pitcher?");
            poundsOfIce = Convert.ToInt32(Console.ReadLine());
            lemonadeRecipe = cupsSugar + manyLemons + poundsOfIce;
            return lemonadeRecipe;
        }

        public int SetPriceOfLemonade()
        {
            Console.WriteLine("How many cents would you like to charge per cup of lemonade?");
            priceOfLemonade = Convert.ToInt32(Console.ReadLine());
            return priceOfLemonade;
        }

        public double PredictProfit(double itemOne)
        {
            if (cupsToSell <= itemOne)
            {
                potentialProfit = cupsToSell * priceOfLemonade;
                Console.WriteLine($"Your potential profit for the day is {potentialProfit} cents.");
                return potentialProfit;
            }
            else
            {
                potentialProfit = itemOne * priceOfLemonade;
                Console.WriteLine("You will run out of cups.");
                Console.WriteLine($"Your potential profit for the day is {potentialProfit} cents.");
                return potentialProfit;
            }
        }
        public double MakeLemonade(double itemOne, double itemTwo, double itemThree)
        {
            //calculates how much lemonade there will be for the day based on 
            //quantity of ingredients in inventory and recipe
            pitcherSugar = itemOne / cupsSugar;
            pitcherLemons = itemTwo / manyLemons;
            pitcherIce = itemThree / poundsOfIce;

            if (pitcherSugar >= pitcherIce && pitcherLemons >= pitcherIce)
            {
                Console.WriteLine($"You can make {pitcherIce} pitchers of lemonade");
                cupsToSell = pitcherIce * 10;
                Console.WriteLine($"You can sell {cupsToSell} cups of lemonade.");
                //ice is limiting reactant
                return cupsToSell;
            }
            else if (pitcherIce >= pitcherSugar && pitcherLemons >= pitcherSugar)
            {
                Console.WriteLine($"You can make {pitcherSugar} pitchers of lemonade");
                cupsToSell = pitcherSugar * 10;
                Console.WriteLine($"You can sell {cupsToSell} cups of lemonade.");
                //sugar is limiting reactant
                return cupsToSell;
            }
            else if (pitcherIce >= pitcherLemons && pitcherSugar >= pitcherLemons)
            {
                Console.WriteLine($"You can make {pitcherLemons} pitchers of lemonade");
                cupsToSell = pitcherLemons * 10;
                Console.WriteLine($"You can sell {cupsToSell} cups of lemonade.");
                //lemons are limiting reactant
                return cupsToSell;
            }
            return x;
        }

        public void RunAd()
        {
            //player can spend money to run an ad in the local paper 
            //if the next day is gonna be like rainy or something
            //this can cost like $3 and give a 10% increase in customer reach
            //perhaps bool isAdDay if true +10% profit
        }

        //last line of big block
    }
}
