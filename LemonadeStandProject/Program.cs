using System;
using System.Collections.Generic;

namespace LemonadeStandProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello there! Thank you for expressing interest in opening your very own lemonade stand(s)." +
                              "What is your name?");

            string userName = Console.ReadLine();

            int numberOfStands = UI.GetIntegerFromUser(userName + ", how many stands would you like to open?");

            int number = 1;
            List<LemonadeStand> stands = new List<LemonadeStand>();

            for (int i = 0; i < numberOfStands; i++)
            {
                LemonadeStand newStand = new LemonadeStand();

                Console.WriteLine("What would you like to call lemonade stand " + number + " ?");

                newStand.Name = Console.ReadLine();

                Console.WriteLine("Lemonade stand " + number + " will be called " + newStand.Name + ".");

                Console.WriteLine("How many cups do you intend to sell each day?");

                newStand.NumberOfItems = Int32.Parse(Console.ReadLine());

                Console.WriteLine(newStand.NumberOfItems + " is a good number to start with especially since stand " + number + " is a newer stand.");

                Console.WriteLine("What will be the selling price for each cup?");

                newStand.PricePerItems = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Customers paying $" + newStand.PricePerItems + " for each cup of lemonade is a perfect price point.");

                Console.WriteLine("For stand " + number + ", how much do you intend to spend on ingredients for the needed to make each cup?");

                newStand.CostPerItems = decimal.Parse(Console.ReadLine());

                Console.WriteLine("I can tell that you have given some thought to the amount you want to spend per cup.");

                Console.WriteLine(newStand.Outcome());



                number++;
            }

        }
    }
}
