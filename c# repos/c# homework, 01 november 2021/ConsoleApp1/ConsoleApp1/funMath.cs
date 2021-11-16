using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct funMath
    {

        public void bigNum()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("what is the first number?");
            int cnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            int cnum2 = Convert.ToInt32(Console.ReadLine());

            if (cnum1 > cnum2)
            {
                Console.WriteLine(cnum1 + " Is the bigger number");
            }
            else
            {
                Console.WriteLine(cnum2 + " is the bigger number");
            }
        }


        public void evenOdd()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("what is the number you want to see is even or odd?");
            int modulous = Convert.ToInt32(Console.ReadLine());
            modulous = modulous % 2;

            if (modulous != 0)
            {
                Console.WriteLine(modulous + " is an odd number");
            }
            else
            {
                Console.WriteLine(modulous + " is an even number");
            }
        }
    }
}
