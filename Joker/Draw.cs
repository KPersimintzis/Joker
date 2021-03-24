using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Joker
{
    class Draw : Display
    {
        public int[] DrawNumbers { get; private set; } = new int[5];
        public int DrawJoker { get; private set; }

        public Draw()
        {
            DrawNumbersInsert();
        }

        private void DrawNumbersInsert()
        {
            Console.WriteLine("Time for the big draw");
            TableGet(DrawNumbers);
            Console.WriteLine();
            TableJokerGet(DrawJoker);
            Thread.Sleep(2000);
            Console.Clear();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"The number {i + 1} is...");
                int number = random.Next(1, 46);
                while (DrawNumbers.Any(x => x == number))
                {
                    number = random.Next(1, 46);
                }
                DrawNumbers[i] = number;
                Thread.Sleep(1000);
                TableGet(DrawNumbers);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("The number joker is...");
            DrawJoker = random.Next(1, 21);
            TableJokerGet(DrawJoker);
            Console.Clear();
            TableGet(DrawNumbers);
            TableJokerGet(DrawJoker);
        }

    }
}
