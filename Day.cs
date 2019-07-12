using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        public double cupsSold;
        public double todayProfit;
        public double theProfitSoFar;
        public double afterPurchaseBalance;
        public double sugarSold;
        public double lemonsSold;
        public double iceSold;
        public double bonus;
        public double x;
        //ctor
        public Day()
        {
            
        }
        //member methods
        public double CupsSold()
        {
            cupsSold++;
            return cupsSold;
        }

        public double SugarSold()
        {
            sugarSold += 0.1;
            return sugarSold;
        }

        public double LemonsSold()
        {
            lemonsSold += 0.1;
            return lemonsSold;
        }

        public double IceSold()
        {
            iceSold += 0.1;
            return iceSold;
        }
        public double TodayProfit(double cupsOfLemonade, double priceOfLemonade)
        {
            todayProfit = cupsOfLemonade * priceOfLemonade + bonus;
            return todayProfit;
        }

        public double TheProfitSoFar(double endMoney, double loanMoney)
        {
            theProfitSoFar = endMoney - 2000;
            theProfitSoFar -= loanMoney;
            return theProfitSoFar;
        }

        public double RunAnAd(double initProfit, bool theresAnAd)
        {
            if (theresAnAd == true)
            {
                bonus = 0.2 * initProfit;
                return bonus;
            }
            return x;
        }

        //last line of big block
    }
}
