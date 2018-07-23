using System;
using System.Collections.Generic;

namespace LemonadeStandProject
{
    public class LemonadeCorporation
    {
        public List<LemonadeStand> Stands { get; set; }

        public static decimal getOverallRevenue()
        {
            decimal OverallRevenue = 0;
            foreach (LemonadeStand stand in Stands)
            {
                OverallRevenue += stand.GetTotalRevenue();
            }
            return OverallRevenue;

        }

        public static decimal getOverallExpenses()
        {
            decimal OverallExpenses = 0;
            foreach (LemonadeStand stand in Stands)
            {
                OverallExpenses += stand.GetTotalExpenses();
            }
            return OverallExpenses;

        }

        public static decimal getOverallProfit()
        {
            decimal OverallProfit = 0;
            foreach (LemonadeStand stand in Stands)
            {
                OverallProfit += stand.GetTotalProfit();
            }
            return OverallProfit;

        }


    }
}
