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
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            for (int i = 0; i < 7; i++)
            {
                newDay.cupsSold = 0;
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
                newStore.GeneratePrices();
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
                Console.WriteLine("---");
                player.SetPriceOfLemonade();
                Console.WriteLine("---");
                player.PredictProfit(StockCups.quantity);
                Console.WriteLine("Begin day?");
                Console.ReadLine();
                Console.Clear();

                do
                {
                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //newCustomer
                        newCustomer.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (newCustomer.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                newCustomer.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                newCustomer.TakeCup(StockCups.quantity);
                                newCustomer.TakeSugar(StockSugar.quantity);
                                newCustomer.TakeLemons(StockLemons.quantity);
                                newCustomer.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();
                            }
                            StockCups.quantity = newCustomer.aCup;
                            player.cashBalance = newCustomer.aMoney;
                            StockSugar.quantity = newCustomer.aSugar;
                            StockLemons.quantity = newCustomer.aLemon;
                            StockIceCubes.quantity = newCustomer.aIce;
                        }
                    }

                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //oldMan
                        oldMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (oldMan.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                oldMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                oldMan.TakeCup(StockCups.quantity);
                                oldMan.TakeSugar(StockSugar.quantity);
                                oldMan.TakeLemons(StockLemons.quantity);
                                oldMan.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = oldMan.aCup;
                            player.cashBalance = oldMan.aMoney;
                            StockSugar.quantity = oldMan.aSugar;
                            StockLemons.quantity = oldMan.aLemon;
                            StockIceCubes.quantity = oldMan.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //businessMan
                        businessMan.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (businessMan.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                businessMan.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                businessMan.TakeCup(StockCups.quantity);
                                businessMan.TakeSugar(StockSugar.quantity);
                                businessMan.TakeLemons(StockLemons.quantity);
                                businessMan.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = businessMan.aCup;
                            player.cashBalance = businessMan.aMoney;
                            StockSugar.quantity = businessMan.aSugar;
                            StockLemons.quantity = businessMan.aLemon;
                            StockIceCubes.quantity = businessMan.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //child
                        child.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (child.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                child.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                child.TakeCup(StockCups.quantity);
                                child.TakeSugar(StockSugar.quantity);
                                child.TakeLemons(StockLemons.quantity);
                                child.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = child.aCup;
                            player.cashBalance = child.aMoney;
                            StockSugar.quantity = child.aSugar;
                            StockLemons.quantity = child.aLemon;
                            StockIceCubes.quantity = child.aIce;
                        }
                    }


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //woman
                        woman.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (woman.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                woman.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                woman.TakeCup(StockCups.quantity);
                                woman.TakeSugar(StockSugar.quantity);
                                woman.TakeLemons(StockLemons.quantity);
                                woman.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = woman.aCup;
                            player.cashBalance = woman.aMoney;
                            StockSugar.quantity = woman.aSugar;
                            StockLemons.quantity = woman.aLemon;
                            StockIceCubes.quantity = woman.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //teenager
                        teenager.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (teenager.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                teenager.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                teenager.TakeCup(StockCups.quantity);
                                teenager.TakeSugar(StockSugar.quantity);
                                teenager.TakeLemons(StockLemons.quantity);
                                teenager.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = teenager.aCup;
                            player.cashBalance = teenager.aMoney;
                            StockSugar.quantity = teenager.aSugar;
                            StockLemons.quantity = teenager.aLemon;
                            StockIceCubes.quantity = teenager.aIce;
                        }
                    }


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //collegeStudent
                        collegeStudent.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (collegeStudent.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                collegeStudent.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                collegeStudent.TakeCup(StockCups.quantity);
                                collegeStudent.TakeSugar(StockSugar.quantity);
                                collegeStudent.TakeLemons(StockLemons.quantity);
                                collegeStudent.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = collegeStudent.aCup;
                            player.cashBalance = collegeStudent.aMoney;
                            StockSugar.quantity = collegeStudent.aSugar;
                            StockLemons.quantity = collegeStudent.aLemon;
                            StockIceCubes.quantity = collegeStudent.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //argonian
                        argonian.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (argonian.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                argonian.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                argonian.TakeCup(StockCups.quantity);
                                argonian.TakeSugar(StockSugar.quantity);
                                argonian.TakeLemons(StockLemons.quantity);
                                argonian.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = argonian.aCup;
                            player.cashBalance = argonian.aMoney;
                            StockSugar.quantity = argonian.aSugar;
                            StockLemons.quantity = argonian.aLemon;
                            StockIceCubes.quantity = argonian.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //athlete
                        athlete.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (athlete.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                athlete.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                athlete.TakeCup(StockCups.quantity);
                                athlete.TakeSugar(StockSugar.quantity);
                                athlete.TakeLemons(StockLemons.quantity);
                                athlete.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = athlete.aCup;
                            player.cashBalance = athlete.aMoney;
                            StockSugar.quantity = athlete.aSugar;
                            StockLemons.quantity = athlete.aLemon;
                            StockIceCubes.quantity = athlete.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //wizard
                        wizard.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (wizard.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                wizard.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                wizard.TakeCup(StockCups.quantity);
                                wizard.TakeSugar(StockSugar.quantity);
                                wizard.TakeLemons(StockLemons.quantity);
                                wizard.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = wizard.aCup;
                            player.cashBalance = wizard.aMoney;
                            StockSugar.quantity = wizard.aSugar;
                            StockLemons.quantity = wizard.aLemon;
                            StockIceCubes.quantity = wizard.aIce;
                        }
                    } 


                    if (newDay.cupsSold < (player.cupsToSell - 1))
                    {
                        //mom
                        mom.DecideToBuy(weather.WeekWeather[i], player.cupsSugar, player.pitcherLemons, player.pitcherIce, player.priceOfLemonade);
                        if (mom.willBuy == true && StockCups.quantity > 0 && StockSugar.quantity > 0 && StockLemons.quantity > 0 && StockIceCubes.quantity > 0)
                        {
                            {

                                mom.MakePurchase(player.priceOfLemonade, player.cashBalance);
                                mom.TakeCup(StockCups.quantity);
                                mom.TakeSugar(StockSugar.quantity);
                                mom.TakeLemons(StockLemons.quantity);
                                mom.TakeIce(StockIceCubes.quantity);

                                newDay.CupsSold();
                                newDay.SugarSold();
                                newDay.LemonsSold();
                                newDay.IceSold();

                            }
                            StockCups.quantity = mom.aCup;
                            player.cashBalance = mom.aMoney;
                            StockSugar.quantity = mom.aSugar;
                            StockLemons.quantity = mom.aLemon;
                            StockIceCubes.quantity = mom.aIce;
                        }
                    } 


                    //last line of customer loop
                } while (newDay.cupsSold < (player.cupsToSell -1));

                newDay.TodayProfit(newDay.cupsSold, player.priceOfLemonade);
                newDay.TheProfitSoFar(player.cashBalance, newTree.givenLoans);
                //the day is now over time for end of day stats
                Console.WriteLine("End of day stats: ");
                Console.WriteLine($"{newDay.cupsSold} cups of lemonade sold");
                Console.WriteLine($"{newDay.todayProfit} cents profit made today");
                Console.WriteLine($"{newDay.theProfitSoFar} cents profit overall");

                //
                newStore.amountToBorrow = 0;

                Console.ReadLine();
                //end of main for loop
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


        }
    }
}
