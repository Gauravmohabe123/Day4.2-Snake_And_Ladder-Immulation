using System;

namespace Snake_And_Ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and ladder immulation");
            int position = 0;
            Random ran = new Random();


            int step = 0;
            while (step < 100)
            {
                int Dice = ran.Next(1, 7);
                Console.WriteLine(Dice);

                int option = ran.Next(0, 3);

                switch (option)
                {
                    case 0:
                        position = position + 0;

                        Console.WriteLine("No play Your position is: " + position);
                        step = position;

                        break;

                    case 1:
                        position = position + Dice;
                        if (position > 100)
                        {
                            position = position - Dice;
                            step = position;


                        }
                        else if (position == 100)
                        {
                            Console.WriteLine("You reached at final home you won the match" + position);
                            step = position;

                        }
                        else
                        {
                            Console.WriteLine("Ladder go ahed your position is :" + position);
                            step = position;

                        }



                        break;
                    case 2:
                        position = position - Dice;

                        if (position < 0)
                        {
                            position = 0;
                        }
                        else
                            Console.WriteLine("Snake  go back your position is : " + position);
                        step = position;

                        break;

                }
            }
        }
    }
}
