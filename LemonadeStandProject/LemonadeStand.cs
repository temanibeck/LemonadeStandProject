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
            decimal totalExpenses = NumberOfItems * CostPerItem;
            return totalExpenses;
        }

        public decimal GetTotalProfit()
        {
            decimal totalProfit = (PricePerItem - CostPerItem) * NumberOfItems;
            return totalProfit;
        }

        public string Outcome()
        {
            string message = " ";
            decimal totalProfit = (PricePerItem - CostPerItem) * NumberOfItems;
            decimal totalRevenue = NumberOfItems * PricePerItem;
            decimal totalExpenses = NumberOfItems * CostPerItem;

            message += ("Your total profit per item will be: " + totalProfit + "." +
                              "\n Your total expenses will be: " + totalRevenue + "." +
                              "\n Your total profit will be: " + totalExpenses + ".");

            return message;
        }

    }
}
