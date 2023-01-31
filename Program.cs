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
            while (step < 20)
            {
                int dice = random.Next(1, 7);
                Console.WriteLine(dice);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play player stayed in the same position");
                        position = position + 0;
                        step = position;
                        break;
                    case 1:
                        Console.WriteLine("The player go ahead");
                        position = position + 1;
                        step = position;
                        break;
                    case 2:
                        position = position - 1;
                        if (position < 0)
                        {
                            position = 0;
                            step = position;
                        }
                        Console.WriteLine("The player go back");
                        
                        break;

                }
            }
        }
    }
}
