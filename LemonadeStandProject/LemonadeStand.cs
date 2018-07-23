using System;
using System.Collections.Generic;

namespace LemonadeStandProject
{
    public class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberOfCups { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }

        public decimal GetTotalRevenue()
        {
            decimal totalRevenue = NumberOfCups * PricePerCup;
            return totalRevenue;
        }

        public decimal GetTotalExpenses()
        {
            decimal totalExpenses = NumberOfCups * CostPerCup;
            return totalExpenses;
        }

        public decimal GetTotalProfit()
        {
            decimal totalProfit = (PricePerCup - CostPerCup) * NumberOfCups;
            return totalProfit;
        }

        public string Outcome()
        {
            string message = " ";
            decimal totalProfit = (PricePerCup - CostPerCup) * NumberOfCups;
            decimal totalRevenue = NumberOfCups * PricePerCup;
            decimal totalExpenses = NumberOfCups * CostPerCup;

            message += ("Your total profit per cup will be: " + totalProfit + "." +
                              "\n Your total expenses will be: " + totalRevenue + "." +
                              "\n Your total profit will be: " + totalExpenses + ".");

            return message;
        }

    }
}
