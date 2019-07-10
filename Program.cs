using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiations
            UserInterface GameInterface = new UserInterface();
            Inventory StockSugar = new Inventory();
            Inventory StockLemons = new Inventory();
            Inventory StockCups = new Inventory();
            Inventory StockIceCubes = new Inventory();
            Player player = new Player();
            Weather weather = new Weather();
            Store newStore = new Store();
            LemonTree newTree = new LemonTree();

            Customer newCustomer = new Customer(2, 3, 3, 2, 25);


            //method calls
            GameInterface.DisplayRules();
            GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
            Console.WriteLine("---");
            GameInterface.DisplayCashBalance(player.cashBalance);
            Console.WriteLine("---");
            weather.GenerateForecast();
            Console.WriteLine("---");

            for (int i = 0; i < 7; i++)
            {

                newStore.WillYouGoToStore();
                Console.WriteLine("---");
                //
                Console.Clear();
                newStore.GeneratePrices();
                newStore.AddToCart(player.cashBalance);
                newTree.PayBack(newStore.amountToBorrow);
                Console.WriteLine("---");
                //
                player.cashBalance = newStore.newBalance;
                //Console.Clear();
                Console.WriteLine($"After making your purchase, you have {player.cashBalance} cents.");
                {
                    StockSugar.quantity += newStore.sugarQuant;
                    StockLemons.quantity += newStore.lemonsQuant;
                    StockCups.quantity += newStore.cupsQuant;
                    StockIceCubes.quantity += newStore.iceQuant;
                }
                GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
                Console.WriteLine("---");
                player.CreateRecipe();
                player.MakeLemonade(StockSugar.quantity, StockLemons.quantity, StockIceCubes.quantity);
                player.SetPriceOfLemonade();
                player.PredictProfit(StockCups.quantity);
                Console.ReadLine();

                //start day

                newCustomer.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade, player.cashBalance, StockCups.quantity);
                newCustomer.MakePurchase(player.priceOfLemonade, player.cashBalance);
                newCustomer.TakeCup(StockCups.quantity);

                {
                    StockCups.quantity = newCustomer.aCup;
                    player.cashBalance = newCustomer.aMoney;
                }
                //the day is now over time for end of day stats
                Console.WriteLine("End of day stats: ");

                //


                Console.ReadLine();
            }
            
        }
    }
}
