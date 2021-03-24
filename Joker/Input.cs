using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joker
{
    abstract class Input
    {
        public static int Integer(int min, int max)
        {
            int tempint;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out tempint) || (tempint < min) || (tempint > max))
            {
                Console.WriteLine("Invalid Number");
                Console.Write($"Please type a number between {min} and {max}: ");
                input = Console.ReadLine();
            }
            return tempint;
        }

        public static bool YesOrNo()
        {
            Console.Write(">");
            string temp = Console.ReadLine();
            if (temp.ToUpper().Equals("Y"))
            {
                Console.WriteLine("");
                return true;
            }
            else if (temp.ToUpper().Equals("N"))
            {
                Console.WriteLine("");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid!Type <Y> or <N>:");
                return YesOrNo();
            }

        }
    }
}
