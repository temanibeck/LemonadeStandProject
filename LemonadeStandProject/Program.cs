using System;

namespace LemonadeStandProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LemonadeStand lemonadeStand = new LemonadeStand();

            Console.WriteLine("Hello there! Thank you for expressing interest " +
                              "in opening your very own lemonade stand. What" +
                              "would you like to call your lemonade stand?");

            lemonadeStand.Name = Console.ReadLine();

            Console.WriteLine("I think that's a lovely name! So you will be opening a lemonade stand called " + lemonadeStand.Name + ".");

            Console.WriteLine("Now let's get down to the numbers. How many cups do you intend to sell?");

            lemonadeStand.NumberOfCups = int.Parse(Console.ReadLine());

            Console.WriteLine(lemonadeStand.NumberOfCups + " is a good number to start with especially since this is a new stand.");

            Console.WriteLine("Now how much do you intend to sell each cup for?");

            lemonadeStand.PricePerCup = double.Parse(Console.ReadLine());

            Console.WriteLine("Customers paying $" + lemonadeStand.PricePerCup + " for each cup of lemonade is a perfect price point.");

            Console.WriteLine("Now tell me how much you intend to spend on ingredients needed to make each cup?");

           lemonadeStand.CostPerCup = double.Parse(Console.ReadLine());

            Console.WriteLine("I can tell that you have given some thought to the amount you want to spend per cup");

            double netProfitPerCup = lemonadeStand.PricePerCup - lemonadeStand.CostPerCup;

            double netProfitTotal = netProfitPerCup * lemonadeStand.NumberOfCups;

            Console.WriteLine("After taking a closer look at your numbers you can anticipate earning $" + netProfitTotal + ".");
        }
    }
}
