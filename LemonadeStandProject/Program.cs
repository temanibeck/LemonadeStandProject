using System;
using System.Collections.Generic;

namespace LemonadeStandProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Thank you for expressing interest in opening your very own lemonade stand." +
                              "What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine(userName + ", how many stands would you like to open?");

            int numberOfStands = Console.ReadLine();

            int number = 1;
            List<LemonadeStand> standNames = new List<LemonadeStand>();

            for (int i = 0; i < numberOfStands; i++)
            {
                LemonadeStand lemonadeStand = new LemonadeStand();

                Console.WriteLine("What would you like to call lemonade stand " + number + "?");

                lemonadeStand.Name = Console.ReadLine();

                Console.WriteLine("Lemonade Stand " + number + "will be called " + lemonadeStand.Name + ".");

                Console.WriteLine("Now let's get down to the numbers. How many cups do you intend to sell?");

                lemonadeStand.NumberOfCups = Int32.Parse(Console.ReadLine());

                Console.WriteLine(lemonadeStand.NumberOfCups + " is a good number to start with especially since this is a new stand.");

                Console.WriteLine("Now how much do you intend to sell each cup for?");

                lemonadeStand.PricePerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Customers paying $" + lemonadeStand.PricePerCup + " for each cup of lemonade is a perfect price point.");

                Console.WriteLine("Now tell me how much you intend to spend on ingredients needed to make each cup?");

                lemonadeStand.CostPerCup = decimal.Parse(Console.ReadLine());

                Console.WriteLine("I can tell that you have given some thought to the amount you want to spend per cup");

                decimal netProfitPerCup 

                decimal netProfitTotal = netProfitPerCup * lemonadeStand1.NumberOfCups;

                Console.WriteLine("After taking a closer look at your numbers you can anticipate earning $" + netProfitTotal + ".");
            }

        }
    }
}
