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
            todayProfit = cupsOfLemonade * priceOfLemonade;
            return todayProfit;
        }

        public int TheProfitSoFar(int endMoney, int loanMoney)
        {
            theProfitSoFar = endMoney - 2000;
            theProfitSoFar -= loanMoney;
            return theProfitSoFar;
        }

        public void SetTheCups(int cupOne, int cupTwo)
        {
            cupOne = cupTwo;
        }

        public void SetTheMoney(int moneyOne, int moneyTwo)
        {
            moneyOne = moneyTwo;
        }


        //last line of big block
    }
}
