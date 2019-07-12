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
        public int theProfitSoFar;
        public int afterPurchaseBalance;

        public int bonus;
        public int x; 
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


        public int TodayProfit(int cupsOfLemonade, int priceOfLemonade)
        {
            todayProfit = cupsOfLemonade * priceOfLemonade + bonus;
            return todayProfit;
        }

        public int TheProfitSoFar(int endMoney, int loanMoney)
        {
            theProfitSoFar = endMoney - 2000;
            theProfitSoFar -= loanMoney;
            return theProfitSoFar;
        }

        public int RunAnAd(int initProfit, bool theresAnAd)
        {
            if (theresAnAd == true)
            {
                bonus = initProfit / 5;
                return bonus;
            }
            return x;
        }

        //last line of big block
    }
}
