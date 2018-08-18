using System;

namespace LemonadeStandProject
{
    public static class UI
    {
        public static int GetIntegerFromUser(string question)
        {
            Console.WriteLine(question);

            int response;
            while(!int.TryParse(Console.ReadLine(), out response))
            {
                Console.WriteLine("Please enter an integer. " + question);
            }

            return response;
        }
    }
}
