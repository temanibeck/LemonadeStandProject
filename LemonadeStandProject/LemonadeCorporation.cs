using System;
using System.Collections.Generic;

namespace LemonadeStandProject
{
    public class LemonadeCorporation
    {
        public static List<LemonadeStand> LemonStands { get; set; }
        public static List<PopsicleStand> PopStands { get; set; }

        public static decimal getOverallRevenue()
        {
            decimal OverallRevenue = 0;
            foreach (LemonadeStand stand in LemonStands)
            {
                OverallRevenue += stand.GetTotalRevenue();
            }
            return OverallRevenue;

        }

        public static decimal getOverallExpenses()
        {
            decimal OverallExpenses = 0;
            foreach (LemonadeStand stand in LemonStands)
            {
                OverallExpenses += stand.GetTotalExpenses();
            }
            return OverallExpenses;

        }

        public static decimal getOverallProfit()
        {
            decimal OverallProfit = 0;
            foreach (LemonadeStand stand in LemonStands)
            {
                OverallProfit += stand.GetTotalProfit();
            }
            return OverallProfit;

        }


    }
}
