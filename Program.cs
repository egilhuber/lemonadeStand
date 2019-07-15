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
            Game newGame = new Game();
            Day newDay = new Day();

            Customer newCustomer = new Customer(2, 3, 3, 10, 25);

            Customer oldMan = new Customer(1, 2, 4, 10, 10);
            Customer businessMan = new Customer(1, 1, 5, 20, 100);
            Customer child = new Customer(0, 5, 4, 20, 25);
            Customer woman = new Customer(4, 2, 4, 20, 75);
            Customer teenager = new Customer(0, 4, 4, 20, 50);
            Customer collegeStudent = new Customer(2, 5, 5, 10, 20);
            Customer argonian = new Customer(4, 2, 4, 10, 100);
            Customer athlete = new Customer(0, 3, 4, 30, 100);
            Customer wizard = new Customer(3, 4, 4, 20, 300);
            Customer mom = new Customer(0, 2, 2, 20, 500);

            Customer ironMan = new Customer(0, 5, 5, 25, 1000);
            Customer captainAmerica= new Customer(1, 2, 3, 10, 50);
            Customer thor = new Customer(2, 3, 3, 10, 15);
            Customer hulk = new Customer(1, 3, 3, 10, 75);
            Customer wonderWoman = new Customer(3, 2, 1, 30, 25);
            Customer batman = new Customer(4, 2, 4, 40, 300);
            Customer deadpool = new Customer(0, 2, 3, 20, 50);
            Customer spiderman = new Customer(1, 3, 3, 10, 200);



            //method calls
            Console.ReadLine(); //remove this line before submitting
            newGame.BeginGame();
            GameInterface.DisplayRules();
            GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
            Console.WriteLine("---");
            GameInterface.DisplayCashBalance(player.cashBalance);
            Console.WriteLine("---");
            weather.GenerateForecast();
            Console.WriteLine("---");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            for (int i = 0; i < 7; i++)
            {
                newDay.cupsSold = 0;
                player.cupsSugar = 0;
                player.manyLemons = 0;
                player.poundsOfIce = 0;
                newDay.bonus = 0;
                Console.Clear();
                Console.WriteLine("---");
                Console.WriteLine($"Day {i + 1}. Expect {weather.WordsWeekWeather[i]} weather.");
                GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
                Console.WriteLine("---");
                GameInterface.DisplayCashBalance(player.cashBalance);
                newStore.WillYouGoToStore();
                Console.WriteLine("---");
                //
                Console.Clear();
                GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
                Console.WriteLine("---");
                GameInterface.DisplayCashBalance(player.cashBalance);
                Console.WriteLine("---");


                try
                {
                     newStore.GeneratePrices();
                     Console.WriteLine($"You spent {newStore.iceTotal} cents on ice.");
                }
                catch
                {
                     Console.WriteLine("Invalid entry.");
                }
                
                
                newStore.AddToCart(player.cashBalance);
                if (newStore.amountToBorrow > 0)
                {
                    newTree.PayBack(newStore.amountToBorrow);
                }
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("---");
                //
                if (newStore.invalidEntry == 0)
                {
                    player.cashBalance = newStore.newBalance;
                }
                else if (newStore.invalidEntry == 1)
                {
                    player.cashBalance -= newStore.cartTotal;
                }
                
                newDay.afterPurchaseBalance = newStore.newBalance;
                //Console.Clear();
                Console.WriteLine($"After making your purchase, you have {player.cashBalance} cents.");
                {
                    StockSugar.quantity += newStore.sugarQuant;
                    StockLemons.quantity += newStore.lemonsQuant;
                    StockCups.quantity += newStore.cupsQuant;
                    StockIceCubes.quantity += newStore.iceQuant;
                }

                try
                {
                    Console.Clear();
                    GameInterface.DisplayInventory(StockSugar.quantity, StockLemons.quantity, StockCups.quantity, StockIceCubes.quantity);
                    Console.WriteLine("---");
                    GameInterface.DisplayRecipe();
                    player.CreateRecipe();
                    player.MakeLemonade(StockSugar.quantity, StockLemons.quantity, StockIceCubes.quantity);
                    player.MakePitcher(StockSugar.quantity, StockLemons.quantity, StockIceCubes.quantity);
                    Console.WriteLine("---");
                    player.SetPriceOfLemonade();
                    Console.WriteLine("---");
                    player.PredictProfit(StockCups.quantity);
                    player.RunAd();

                }
                catch
                {
                    Console.WriteLine("Invalid entry.");
                }

                newGame.StartDay();

                for (int q = 0; q < 5; q++)
                {
                    //newCustomer
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        newCustomer.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (newCustomer.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                newCustomer.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                newCustomer.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = newCustomer.aCup;
                                player.cashBalance = newCustomer.aMoney;
                            }

                        }
                    }

                    //oldMan
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        oldMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (oldMan.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                oldMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                oldMan.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = oldMan.aCup;
                                player.cashBalance = oldMan.aMoney;
                            }

                        }
                    } 

                    //businessMan
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        businessMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (businessMan.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                businessMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                businessMan.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = businessMan.aCup;
                                player.cashBalance = businessMan.aMoney;
                            }

                        }
                    } 

                    //child
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        child.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (child.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                child.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                child.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = child.aCup;
                                player.cashBalance = child.aMoney;
                            }

                        }
                    }

                    //woman
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        woman.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (woman.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                woman.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                woman.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = woman.aCup;
                                player.cashBalance = woman.aMoney;
                            }

                        }
                    } 

                    //teenager
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        teenager.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (teenager.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                teenager.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                teenager.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = teenager.aCup;
                                player.cashBalance = teenager.aMoney;
                            }

                        }
                    }

                    //collegeStudent
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        collegeStudent.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (collegeStudent.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                collegeStudent.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                collegeStudent.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = collegeStudent.aCup;
                                player.cashBalance = collegeStudent.aMoney;
                            }

                        }
                    } 

                    //argonian
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        argonian.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (argonian.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                argonian.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                argonian.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = argonian.aCup;
                                player.cashBalance = argonian.aMoney;
                            }

                        }
                    } 

                    //athlete
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        athlete.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (athlete.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                athlete.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                athlete.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = athlete.aCup;
                                player.cashBalance = athlete.aMoney;
                            }

                        }
                    } 

                    //wizard
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        wizard.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (wizard.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                wizard.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                wizard.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = wizard.aCup;
                                player.cashBalance = wizard.aMoney;
                            }

                        }
                    } 

                    //mom
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        mom.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (mom.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                mom.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                mom.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = mom.aCup;
                                player.cashBalance = mom.aMoney;
                            }

                        }
                    }

                    //ironMan
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        ironMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (ironMan.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                ironMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                ironMan.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = ironMan.aCup;
                                player.cashBalance = ironMan.aMoney;
                            }

                        }
                    }

                    //captainAmerica
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        captainAmerica.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (captainAmerica.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                captainAmerica.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                captainAmerica.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = captainAmerica.aCup;
                                player.cashBalance = captainAmerica.aMoney;
                            }

                        }
                    }

                    //thor
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        thor.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (thor.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                thor.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                thor.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = thor.aCup;
                                player.cashBalance = thor.aMoney;
                            }

                        }
                    }

                    //hulk
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        hulk.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (hulk.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                hulk.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                hulk.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = hulk.aCup;
                                player.cashBalance = hulk.aMoney;
                            }

                        }
                    }

                    //wonderWoman
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        wonderWoman.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (wonderWoman.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                wonderWoman.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                wonderWoman.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = wonderWoman.aCup;
                                player.cashBalance = wonderWoman.aMoney;
                            }

                        }
                    }

                    //batman
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        batman.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (batman.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                batman.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                batman.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = batman.aCup;
                                player.cashBalance = batman.aMoney;
                            }

                        }
                    }

                    //deadpool
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        deadpool.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (deadpool.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                deadpool.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                deadpool.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = deadpool.aCup;
                                player.cashBalance = deadpool.aMoney;
                            }

                        }
                    }

                    //spiderman
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        spiderman.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (spiderman.willBuy == true && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                spiderman.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                spiderman.TakeCup(StockCups.quantity);

                                newDay.CupsSold();
                                StockCups.quantity = spiderman.aCup;
                                player.cashBalance = spiderman.aMoney;
                            }

                        }
                    }


                    //last line of customer loop
                } 

                newDay.TodayProfit(newDay.cupsSold, player.priceOfLemonade);
                newDay.RunAnAd(newDay.todayProfit, player.ad);
                newDay.TodayProfit(newDay.cupsSold, player.priceOfLemonade);
                newDay.TheProfitSoFar(player.cashBalance, newTree.givenLoans);

                player.ReduceSugar();
                player.ReduceLemons();
                player.ReduceIce();

                StockSugar.quantity -= player.reduceSugar;
                StockLemons.quantity -= player.reduceLemons;
                StockIceCubes.quantity -= player.reduceIce;


                //the day is now over time for end of day stats
                Console.Clear();
                Console.WriteLine("End of day stats: ");
                Console.WriteLine($"{newDay.cupsSold} cups of lemonade sold");
                Console.WriteLine($"{newDay.todayProfit} cents profit made today");
                Console.WriteLine($"{newDay.theProfitSoFar} cents profit overall");

                newStore.amountToBorrow = 0;

                Console.ReadLine();
                //end of loop
            }

            newDay.TheProfitSoFar(player.cashBalance, newTree.givenLoans);
            Console.WriteLine("End of game");
            Console.WriteLine($"{newDay.theProfitSoFar} cents profit overall");
            if (newDay.theProfitSoFar > 0)
            {
                Console.WriteLine("Congratulations, you made a profit!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You tried");
                Console.ReadLine();
            }

            //last line of static main
        }
    }
}
