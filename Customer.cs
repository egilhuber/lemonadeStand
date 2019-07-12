using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        public double weatherPref;
        public double sugarPref;
        public double lemonPref;
        public double icePref;
        public double costPref;
        public bool willBuy;
        public double x = 1;
        public double aMoney;
        public double aCup;
        public double aSugar;
        public double aLemon;
        public double aIce;

        //ctor
        public Customer(int weatherPref, double sugarPref, double lemonPref, double icePref, double costPref)
        {
            this.weatherPref = weatherPref;
            this.sugarPref = sugarPref;
            this.lemonPref = lemonPref;
            this.icePref = icePref;
            this.costPref = costPref;
        }
        //member methods
        public bool DecideToBuy(int theWeather, double theSugar, double theLemons, double theIce, int theCost)
        {
            if (theWeather == weatherPref && theCost <= costPref)
            {
                //true
                willBuy = true;
                return willBuy;
            }
            else if (theSugar == sugarPref || theLemons == lemonPref && theWeather == weatherPref)
            {
                //true
                willBuy = true;
                return willBuy;
            }
            else if (theIce >= icePref && theCost <= costPref)
            {
                //true
                willBuy = true;
                return willBuy;
            }
            else
            {
                //false
                willBuy = false;
                return willBuy;
            }
            //last line of decide to buy
        }

        public double MakePurchase(double theCost, double cashRegister)//add cup and cost parameters then put the buy/exchange in
        {
            if (willBuy == true)
            {
                ExchangeMoney(cashRegister, theCost);
                return aMoney;
            }
            else
            {
                return x;
            }
        }

        public double TakeCup(double theCups)
        {
            if (willBuy == true)
            {
                BuyCup(theCups);
                return aCup;
            }
            else
            {
                return x;
            }

        }

        public double TakeIce(double theIces)
        {
            if (willBuy == true)
            {
                BuyIce(theIces);
                return aIce;
            }
            else
            {
                return x;
            }
        }

        public double TakeLemons(double theLemons)
        {
            if(willBuy == true)
            {
                BuyLemons(theLemons);
                return aLemon;
            }
            else
            {
                return x;
            }
        }

        public double TakeSugar(double theSugars)
        {
            if (willBuy == true)
            {
                BuySugar(theSugars);
                return aSugar;
            }
            else
            {
                return x;
            }
        }

        public double BuyCup(double someCups)
        {
            aCup = someCups - 1;
            return aCup;
        }

        public double BuyIce(double someIce)
        {
            aIce = someIce - 0.1;
            return aIce;
        }

        public double BuyLemons(double someLemons)
        {
            aLemon = someLemons - 0.1;
            return aLemon;
        }

        public double BuySugar(double someSugar)
        {
            aSugar = someSugar - 0.1;
            return aSugar;
        }
        public double ExchangeMoney(double someMoney, double someCost)
        {
            aMoney = someMoney + someCost;
            return aMoney;
        }

        //last line of big block
    }
}
