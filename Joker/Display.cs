using System;
using System.Linq;

namespace Joker
{
    abstract class Display
    {
        private static int[,] Table = new int[5, 9];
        public static int[,] TableJoker = new int[5, 4];

        static Display()
        {
            int s = 1;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Table[i, j] = s;
                    s++;
                }
            }
            s = 1;
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    TableJoker[i, j] = s;
                    s++;
                }
            }
        }

        protected void TableGet(int[] DrawFive)
        {
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (DrawFive.Any(x => x == Table[i, j]))
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(Table[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("");
                    }
                    else
                    { Console.Write(Table[i, j] + " "); }
                }
                Console.WriteLine("");
            }
        }
        protected void TableJokerGet(int DrawJoker)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (DrawJoker == Table[i, j])
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(TableJoker[i, j] + " ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    { Console.Write(TableJoker[i, j] + " "); }
                }
                Console.WriteLine("");
            }
        }




    }
}
