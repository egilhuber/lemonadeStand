using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables
        public string toTheStore;
        public double sugarPrice;
        public double lemonsPrice;
        public double cupsPrice;
        public double icePrice;

        public double sugarQuant;
        public double lemonsQuant;
        public double cupsQuant;
        public double iceQuant;

        public double sugarTotal;
        public double lemonsTotal;
        public double cupsTotal;
        public double iceTotal;

        public double cartTotal;
        public double newBalance;
        public double amountToBorrow = 0;



        public double x = 1;

        //ctor
        public Store()
        {

        }
        //member methods

        public string WillYouGoToStore()
        {
            Console.WriteLine("Press enter to go to the store.");
            toTheStore = Console.ReadLine();
            return toTheStore;
        }

        public int RandomNumber(int min, int max)
        {
            Random itemPrice = new Random();
            return itemPrice.Next(min, max);
        }

        public double GeneratePrices()
        {
            SellSugar();
            sugarTotal = sugarPrice * sugarQuant;
            SellLemons();
            lemonsTotal = lemonsPrice * lemonsQuant;
            SellCups();
            cupsTotal = cupsPrice * cupsQuant;
            SellIce();
            iceTotal = icePrice * iceQuant;
            cartTotal = sugarTotal + lemonsTotal + cupsTotal + iceTotal;
            return cartTotal;

            //last line of generateprices method
        }

        public double SellSugar()
        {
            sugarPrice = RandomNumber(10, 30);
            Console.WriteLine($"Sugar is {sugarPrice} cents per pound.");
            Console.WriteLine("How many cups of sugar would you like to purchase?");
            sugarQuant = Convert.ToInt32(Console.ReadLine());
            return sugarQuant;
        }

        public double SellLemons()
        {
            lemonsPrice = RandomNumber(10, 20);
            Console.WriteLine($"You spent {sugarTotal} cents on sugar");
            Console.WriteLine("---");
            Console.WriteLine($"Lemons are {lemonsPrice} cents each.");
            Console.WriteLine("How many lemons would you like to purchase?");
            lemonsQuant = Convert.ToInt32(Console.ReadLine());
            return lemonsQuant;
        }

        public double SellCups()
        {
            cupsPrice = RandomNumber(1, 15);
            Console.WriteLine($"You spent {lemonsTotal} cents on lemons.");
            Console.WriteLine("---");
            Console.WriteLine($"Cups are {cupsPrice} cents each");
            Console.WriteLine("How many cups would you like to purchase?");
            cupsQuant = Convert.ToInt32(Console.ReadLine());
            return cupsQuant;
        }

        public double SellIce()
        {
            icePrice = RandomNumber(1, 35);
            Console.WriteLine($"You spent {cupsTotal} cents on cups.");
            Console.WriteLine("---");
            Console.WriteLine($"Ice is {icePrice} cents per pound.");
            Console.WriteLine("How many pounds of ice would you like to purchase?");
            iceQuant = Convert.ToInt32(Console.ReadLine());
            return iceQuant;
        }

        public double AddToCart(double balance)
        {
            string response;
            Console.WriteLine("---");
            Console.WriteLine($"You have {balance} cents. Your cart total is: {cartTotal} cents. Complete purchase?");
            response = Console.ReadLine();
            if (response == "yes" && balance > cartTotal)
            {
                newBalance = balance - cartTotal;
                Console.WriteLine($"Your new balance is {newBalance} cents");
                return newBalance;
            }
            else if (response == "yes" && balance < cartTotal)
            {
                Console.WriteLine("Insufficient funds. How much would you like to borrow from the lemon tree?");
                BorrowMoney();
                newBalance = balance + amountToBorrow;
                Console.WriteLine($"Your new balance before purchase is {newBalance} cents.");
                newBalance -= cartTotal;
                return newBalance;
            }
            else if (response == "no")
            {
                EmptySugar();
                EmptyLemons();
                EmptyCups();
                EmptyIce();
                Console.WriteLine("Cart has been emptied.");
                newBalance = balance;
                return newBalance;
            }
            else
            {
                Console.WriteLine("Invalid entry");
                Console.ReadLine();
            }
            return x;
                
        }

        public double BorrowMoney()
        {
            amountToBorrow += Convert.ToInt32(Console.ReadLine());
            return amountToBorrow;
        }

        public double EmptySugar()
        {
            sugarQuant = 0;
            return sugarQuant;
        }

        public double EmptyLemons()
        {
            lemonsQuant = 0;
            return lemonsQuant;
        }

        public double EmptyCups()
        {
            cupsQuant = 0;
            return cupsQuant;
        }

        public double EmptyIce()
        {
            iceQuant = 0;
            return iceQuant;
        }
        
        

        //last line of big block
    }
}
