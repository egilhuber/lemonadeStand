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
        public int cashBalance;

        public double cupsSugar;
        public double manyLemons;
        public double poundsOfIce;
        public double lemonadeRecipe;
        public int priceOfLemonade;

        public double pitcherSugar;
        public double pitcherLemons;
        public double pitcherIce;

        public double manyPitchers;

        public double reduceSugar;
        public double reduceLemons;
        public double reduceIce;

        public bool ad;

        public double cupsToSell;

        public double potentialProfit;

        public int x = 1;

        
        //ctor
        public Player()
        {
            cashBalance = 2000;
        }
        //member methods

        public double CreateRecipe()
        {
            CupsSugar();
            Console.WriteLine("---");
            ManyLemons();
            Console.WriteLine("---");
            PoundsOfIce();
            Console.WriteLine("---");
            lemonadeRecipe = cupsSugar + manyLemons + poundsOfIce;
            return lemonadeRecipe;
        }

        public double CupsSugar()
        {
            Console.WriteLine("How many cups of sugar would you like per pitcher?");
            cupsSugar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your recipe will have {cupsSugar} cups of sugar per pitcher.");
            return cupsSugar;
        }

        public double ManyLemons()
        {
            Console.WriteLine("How many lemons would you like per pitcher?");
            manyLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your recipe will have {manyLemons} lemons per pitcher.");
            return manyLemons;
        }

        public double PoundsOfIce()
        {
            Console.WriteLine("How many ice cubes would you like per pitcher?");
            poundsOfIce = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your recipe will have {poundsOfIce} ice cubes per pitcher.");
            return poundsOfIce;
        }

        public int SetPriceOfLemonade()
        {
            Console.WriteLine("How many cents would you like to charge per cup of lemonade?");
            priceOfLemonade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your lemonade will cost {priceOfLemonade} cents per cup.");
            return priceOfLemonade;
        }

        public double PredictProfit(double itemOne)
        {
            if (cupsToSell <= itemOne)
            {
                potentialProfit = cupsToSell * priceOfLemonade;
                Console.WriteLine($"Your potential profit for the day is {potentialProfit} cents.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                return potentialProfit;
            }
            else
            {
                potentialProfit = itemOne * priceOfLemonade;
                Console.WriteLine("You will run out of cups.");
                Console.WriteLine($"Your potential profit for the day is {potentialProfit} cents.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
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

        public int AfterAdBalance()
        {
            cashBalance -= 50;
            return cashBalance;
        }

        public bool RunAd()
        {
            //player can spend money to run an ad in the local paper 
            //if the next day is gonna be like rainy or something
            //this can cost like $3 and give a 10% increase in customer reach
            //perhaps bool isAdDay if true +10% profit
            Console.Clear();
            string response;
            Console.WriteLine("You may run an ad in the local paper for 50 cents. \n" +
                "This will increaese your revenue by 20%. \n" +
                $"Your current balance is {cashBalance} cents. \n" +
                $"Would you like to run an ad?");
            response = Console.ReadLine();
            if (response == "yes" || response == "Yes" || response == "y" || response == "YES")
            {
                if (cashBalance > 49)
                {
                    ad = true;
                    AfterAdBalance();
                    Console.WriteLine("Your ad will be published in the next morning paper.");
                    Console.WriteLine($"Your new balance is {cashBalance} cents.");
                    Console.ReadLine();
                    return ad;
                }
                else
                {
                    ad = false;
                    Console.WriteLine("You do not have the funds to run an ad.");
                    System.Threading.Thread.Sleep(1400);
                    return ad;
                }

            }
            else
            {
                ad = false;
                Console.WriteLine("No ad will be run.");
                Console.ReadLine();
                return ad;
            }

        }


        public double MakePitcher(double itemOne, double itemTwo, double itemThree)
        {
            //calculates how much lemonade there will be for the day based on 
            //quantity of ingredients in inventory and recipe
            pitcherSugar = itemOne / cupsSugar;
            pitcherLemons = itemTwo / manyLemons;
            pitcherIce = itemThree / poundsOfIce;

            if (pitcherSugar >= pitcherIce && pitcherLemons >= pitcherIce)
            {
                manyPitchers = pitcherSugar;
                return manyPitchers;
            }
            else if (pitcherIce >= pitcherSugar && pitcherLemons >= pitcherSugar)
            {
                manyPitchers = pitcherSugar;
                return manyPitchers;
            }
            else if (pitcherIce >= pitcherLemons && pitcherSugar >= pitcherLemons)
            {
                manyPitchers = pitcherLemons;
                return manyPitchers;
            }
            return x;
        }





        public double ReduceSugar()
        {
            reduceSugar = cupsSugar / 10;
            return reduceSugar;
        }

        public double ReduceLemons()
        {
            reduceLemons = manyLemons / 10;
            return reduceLemons;
        }

        public double ReduceIce()
        {
            reduceIce = poundsOfIce / 10;
            return reduceIce;
        }

        //last line of big block
    }
}
