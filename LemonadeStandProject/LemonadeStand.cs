using System;
using System.Collections.Generic;

namespace LemonadeStandProject
{
    public class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberOfItems { get; set; }
        public decimal PricePerItems { get; set; }
        public decimal CostPerItems { get; set; }

        public decimal GetTotalRevenue()
        {
            decimal totalRevenue = NumberOfItems * PricePerItems;
            return totalRevenue;
        }

        public decimal GetTotalExpenses()
        {
            decimal totalExpenses = NumberOfItems * CostPerItems;
            return totalExpenses;
        }

        public decimal GetTotalProfit()
        {
            decimal totalProfit = (PricePerItems - CostPerItems) * NumberOfItems;
            return totalProfit;
        }

        public string Outcome()
        {
            string message = " ";
            decimal totalProfit = (PricePerItems - CostPerItems) * NumberOfItems;
            decimal totalRevenue = NumberOfItems * PricePerItems;
            decimal totalExpenses = NumberOfItems * CostPerItems;

            message += ("Your total profit per item will be: " + totalProfit + "." +
                              "\n Your total expenses will be: " + totalRevenue + "." +
                              "\n Your total profit will be: " + totalExpenses + ".");

            return message;
        }

    }
}
