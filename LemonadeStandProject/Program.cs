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
        }
    }
}
