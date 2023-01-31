using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and Ladder game immulation");
            int position = 0;
            int step = 0;
            Random random= new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine(dice);
        }
    }
}
