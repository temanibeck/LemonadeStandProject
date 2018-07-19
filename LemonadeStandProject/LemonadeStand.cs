using System;
namespace LemonadeStandProject
{
    public class LemonadeStand
    {
        public string Name { get; set; }
        public int NumberOfCups { get; set; }
        public decimal PricePerCup { get; set; }
        public decimal CostPerCup { get; set; }

        public decimal DailyNetProfitPerCup(decimal PricePerCup, decimal CostPerCup)
        {
            decimal NetProfitPerCup = PricePerCup - CostPerCup;
            return NetProfitPerCup;
        }

        public decimal DailyNetProfitTotal(decimal NetProfitPerCup, decimal NumberOfCups)
        {
            decimal NetProfitTotal = PricePerCup  CostPerCup;
            return NetProfitTotal;
        }
    }
}
