using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Joker
{
    class User : Input
    {
        private static int id = 1;
        public int Id { get; private set; }
        public int[] UserNumbers { get; set; } = new int[5];
        public int UserJoker { get; set; }

        public User(int id)
        {
            Id = id;
        }

        public void Insert()
        {
            int n = 0;
            while (n < 5)
            {
                int[] result;
                Display();
                do
                {
                    Console.Write($"Please Insert a number from 1 to 45\nNumber {n + 1}\n>");
                    UserNumbers[n] = Integer(1, 45);
                    result = Array.FindAll(UserNumbers, x => x == UserNumbers[n]);
                    Console.Write($"You choose number {UserNumbers[n]}\nProceed <Y> or <N> ?\n");
                } while (false);//((!YesOrNo()) || (result.Length > 1));
                n++;
            }
            InsertJoker();

        }

        public void InsertJoker()
        {
            do
            {
                Display();
                Console.Write($"Please Insert Joker Number from 1 to 20\n>");
                UserJoker = Integer(1, 20);
                Console.Write($"You choose number{UserJoker}\nProceed <Y> or <N> ?\n");
            } while (!YesOrNo());
        }


        public void Display()
        {
            Console.Clear();
            for (int i = 0; i < UserNumbers.Length; i++)
            {
                Console.WriteLine($"Number {i + 1}: {UserNumbers[i]}");
            }
        }

        public void Results(int[] numbers, int joker)
        {
            Console.WriteLine($"Player with id:{Id}\nwith numbers:");
            Array.ForEach(UserNumbers, x => Console.Write(x+" "));
            Console.WriteLine($"and with joker Number:{UserJoker} has won....");
            Thread.Sleep(2000);
            var winningNumber = UserNumbers.Intersect(numbers);
            bool result = UserJoker.Equals(joker);
            int jk = 0;
            if (result) { jk = 1; }
            Console.Write($"{winningNumber.Count()*1000 + jk*2000} euros");




        }

    }
}
