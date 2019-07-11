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
        public int cupsSold;
        public int todayProfit;
        public double theProfitSoFar;
        public double afterPurchaseBalance;
        public double sugarSold;
        public double lemonsSold;
        public double iceSold;
        //ctor
        public Day()
        {
            
        }
        //member methods
        public int CupsSold()
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
        public int TodayProfit(int cupsOfLemonade, int priceOfLemonade)
        {
            todayProfit = cupsOfLemonade * priceOfLemonade;
            return todayProfit;
        }

        public double TheProfitSoFar(double endMoney, double loanMoney)
        {
            theProfitSoFar = endMoney - 2000;
            theProfitSoFar -= loanMoney;
            return theProfitSoFar;
        }


        //last line of big block
    }
}
