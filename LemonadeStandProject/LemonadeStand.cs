using System;

namespace LemonadeStandProject
{
    public class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberOfCups { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }

        public string Outcome()
        {
            string message = " ";
            decimal profitPerCup = PricePerCup - CostPerCup;
            decimal totalRevenue = NumberOfCups * PricePerCup;
            decimal totalExpenses = NumberOfCups * CostPerCup;

            message += ("Your total profit per cup will be: " + profitPerCup + "." + 
                              "\n Your total expenses will be: " + totalRevenue + "." + 
                              "\n Your total profit will be: " + totalExpenses +  "." );

            return message;
        }

    }
}
