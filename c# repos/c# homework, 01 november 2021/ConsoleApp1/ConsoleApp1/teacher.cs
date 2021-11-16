using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class teacher
    {
        public void multiply()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("what is the first number?");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("a number multiplied by 0 will always be 0");
            }
            else
            {
                int mResult = num1 * num2;
                Console.WriteLine("The solution is " + mResult);
            }
        }

        public void divide()
        {

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("what is the first number?");
            int dnum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the second number?");
            int dnum2 = Convert.ToInt32(Console.ReadLine());

            if (dnum1 == 0 || dnum2 == 0)
            {
                Console.WriteLine("you may not divide by 0");
            }
            else
            {
                int dResult = dnum1 / dnum2;
                Console.WriteLine("The solution is " + dResult);
            }
        }
    }
}
