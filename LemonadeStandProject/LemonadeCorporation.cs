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

        public static List<LemonadeStand> getOverallExpenses()
        {
            decimal OverallExpenses = NumberOfCups * CostPerCup
        }

        public static List<LemonadeStand> getOverallProfit()
        {
            decimal OverallProfit = PricePerCup - CostPerCup
        }

        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }
        public decimal Profit { get; set; }

    }
}
