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
        public int sugarPrice;
        public int lemonsPrice;
        public int cupsPrice;
        public int icePrice;

        public int sugarQuant;
        public int lemonsQuant;
        public int cupsQuant;
        public int iceQuant;

        public int sugarTotal;
        public int lemonsTotal;
        public int cupsTotal;
        public int iceTotal;

        public int invalidEntry;

        public int cartTotal;
        public int newBalance;
        public int amountToBorrow = 0;



        public int x = 1;

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

        public int GeneratePrices()
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

        public int SellSugar()
        {
            sugarPrice = RandomNumber(1, 10);
            Console.WriteLine($"Sugar is {sugarPrice} cents per cup.");
            Console.WriteLine("How many cups of sugar would you like to purchase?");
            sugarQuant = Convert.ToInt32(Console.ReadLine());
            return sugarQuant;
        }

        public int SellLemons()
        {
            lemonsPrice = RandomNumber(1, 10);
            Console.WriteLine($"You spent {sugarTotal} cents on sugar");
            Console.WriteLine("---");
            Console.WriteLine($"Lemons are {lemonsPrice} cents each.");
            Console.WriteLine("How many lemons would you like to purchase?");
            lemonsQuant = Convert.ToInt32(Console.ReadLine());
            return lemonsQuant;
        }

        public int SellCups()
        {
            cupsPrice = RandomNumber(1, 15);
            Console.WriteLine($"You spent {lemonsTotal} cents on lemons.");
            Console.WriteLine("---");
            Console.WriteLine($"Cups are {cupsPrice} cents each");
            Console.WriteLine("How many cups would you like to purchase?");
            cupsQuant = Convert.ToInt32(Console.ReadLine());
            return cupsQuant;
        }

        public int SellIce()
        {
            icePrice = RandomNumber(1, 10);
            Console.WriteLine($"You spent {cupsTotal} cents on cups.");
            Console.WriteLine("---");
            Console.WriteLine($"Ice is {icePrice} cents per cube.");
            Console.WriteLine("How many ice cubes would you like to purchase?");
            iceQuant = Convert.ToInt32(Console.ReadLine());
            return iceQuant;
        }

        public int AddToCart(int balance)
        {
            invalidEntry = 0;
            string response;
            Console.WriteLine("---");
            Console.WriteLine($"You have {balance} cents. Your cart total is: {cartTotal} cents. \n" +
                $"Enter y to confirm purchase. Enter n to cancel.");
            response = Console.ReadLine();
            if (response == "y" && balance > cartTotal || response == "Y" && balance > cartTotal)
            {
                newBalance = balance - cartTotal;
                Console.WriteLine($"Your new balance is {newBalance} cents");
                return newBalance;
            }
            else if (response == "y" && balance < cartTotal || response == "Y" && balance < cartTotal)
            {
                Console.WriteLine("Insufficient funds! How much would you like to borrow from The Lemon Tree?");
                BorrowMoney();
                newBalance = balance + amountToBorrow;
                Console.WriteLine($"Your new balance before purchase is {newBalance} cents.");
                newBalance -= cartTotal;
                return newBalance;
            }
            else if (response == "n" || response == "N")
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
                invalidEntry = 1;
                return invalidEntry;
            }
                
        }

        public int BorrowMoney()
        {
            amountToBorrow += Convert.ToInt32(Console.ReadLine());
            return amountToBorrow;
        }

        public int EmptySugar()
        {
            sugarQuant = 0;
            return sugarQuant;
        }

        public int EmptyLemons()
        {
            lemonsQuant = 0;
            return lemonsQuant;
        }

        public int EmptyCups()
        {
            cupsQuant = 0;
            return cupsQuant;
        }

        public int EmptyIce()
        {
            iceQuant = 0;
            return iceQuant;
        }
        
        

        //last line of big block
    }
}
