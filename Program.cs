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

            Day newDay = new Day();

            Customer newCustomer = new Customer(2, 3, 3, 2, 25);

            Customer oldMan = new Customer(1, 2, 4, 1, 10);
            Customer businessMan = new Customer(1, 1, 5, 2, 100);
            Customer child = new Customer(0, 5, 4, 2, 25);
            Customer woman = new Customer(4, 2, 4, 2, 75);
            Customer teenager = new Customer(0, 4, 4, 2, 50);
            Customer collegeStudent = new Customer(2, 5, 5, 1, 20);
            Customer argonian = new Customer(4, 2, 4, 1, 100);
            Customer athlete = new Customer(0, 3, 4, 3, 100);
            Customer wizard = new Customer(3, 4, 4, 2, 300);
            Customer mom = new Customer(0, 2, 2, 2, 500);


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
                Console.WriteLine("---");
                Console.WriteLine($"Day {i + 1}. Expect {weather.WordsWeekWeather[i]} weather.");
                GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
                Console.WriteLine("---");
                GameInterface.DisplayCashBalance(player.cashBalance);
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
                newDay.afterPurchaseBalance = newStore.newBalance;
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

                for (int j = 0; j < 10; j++)
                {
                    //newCustomer
                    newCustomer.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (newCustomer.willBuy == true)
                    {
                        {
                        
                            newCustomer.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            newCustomer.TakeCup(StockCups.quantity);

                            newDay.CupsSold();
                        }
                        StockCups.quantity = newCustomer.aCup;
                        player.cashBalance = newCustomer.aMoney;
                    }
                    
                    //oldMan
                    oldMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (oldMan.willBuy == true)
                    {
                        {

                            oldMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            oldMan.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = oldMan.aCup;
                        player.cashBalance = oldMan.aMoney;
                    }


                    //businessMan
                    businessMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (businessMan.willBuy == true)
                    {
                        {

                            businessMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            businessMan.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = businessMan.aCup;
                        player.cashBalance = businessMan.aMoney;
                    }


                    //child
                    child.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (child.willBuy == true)
                    {
                        {

                            child.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            child.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = child.aCup;
                        player.cashBalance = child.aMoney;
                    }


                    //woman
                    woman.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (woman.willBuy == true)
                    {
                        {

                            woman.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            woman.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = woman.aCup;
                        player.cashBalance = woman.aMoney;
                    }


                    //teenager
                    teenager.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (teenager.willBuy == true)
                    {
                        {

                            teenager.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            teenager.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = teenager.aCup;
                        player.cashBalance = teenager.aMoney;
                    }


                    //collegeStudent
                    collegeStudent.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (collegeStudent.willBuy == true)
                    {
                        {

                            collegeStudent.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            collegeStudent.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = collegeStudent.aCup;
                        player.cashBalance = collegeStudent.aMoney;
                    }


                    //argonian
                    argonian.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (argonian.willBuy == true)
                    {
                        {

                            argonian.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            argonian.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = argonian.aCup;
                        player.cashBalance = argonian.aMoney;
                    }


                    //athlete
                    athlete.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (athlete.willBuy == true)
                    {
                        {

                            athlete.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            athlete.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = athlete.aCup;
                        player.cashBalance = athlete.aMoney;
                    }


                    //wizard
                    wizard.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (wizard.willBuy == true)
                    {
                        {

                            wizard.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            wizard.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = wizard.aCup;
                        player.cashBalance = wizard.aMoney;
                    }


                    //mom
                    mom.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                    if (mom.willBuy == true)
                    {
                        {

                            mom.MakePurchase(player.priceOfLemonade, player.cashBalance);
                            mom.TakeCup(StockCups.quantity);

                            newDay.CupsSold();

                        }
                        StockCups.quantity = mom.aCup;
                        player.cashBalance = mom.aMoney;
                    }

                    //last line of customer loop
                }

                newDay.TodayProfit(newDay.cupsSold, player.priceOfLemonade);
                newDay.TheProfitSoFar(player.cashBalance, newTree.givenLoans);
                //the day is now over time for end of day stats
                Console.WriteLine("End of day stats: ");
                Console.WriteLine($"{newDay.cupsSold} cups of lemonade sold");
                Console.WriteLine($"{newDay.todayProfit} cents profit made today");
                Console.WriteLine($"{newDay.theProfitSoFar} cents profit overall");

                //


                Console.ReadLine();
                //end of main for loop
            }

            newDay.TheProfitSoFar(player.cashBalance, newTree.givenLoans);
            Console.WriteLine("End of game");
            Console.WriteLine($"{newDay.theProfitSoFar} cents profit overall");
            if (newDay.theProfitSoFar > 0)
            {
                Console.WriteLine("Congratulations, you made a profit!");
            }
            else
            {
                Console.WriteLine("You tried");
            }


        }
    }
}
