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
        }
    }
}
