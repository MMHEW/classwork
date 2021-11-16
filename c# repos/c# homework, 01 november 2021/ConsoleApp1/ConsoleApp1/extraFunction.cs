using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct extraFunction
    {
        public void choice1()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Random rnd = new Random();
            bool winFlag = false;
            Console.WriteLine("you chose a random number game");
            int randomNumber = rnd.Next(1, 100);
            Console.WriteLine("the computer has chosen a random number between 1 and 100");
            Console.WriteLine(randomNumber);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please give your {0} guess now", i + 1);
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == randomNumber)
                {
                    winFlag = true;
                    i = 3;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("The number you are looking for is higher then that!");
                }
                else
                {
                    Console.WriteLine("The number you are looking for is lower then that!");
                }
            }

            if (winFlag)
            {
                Console.WriteLine("congratulations you win!!");
            }
            else
            {
                Console.WriteLine("I'm sorry but you lost");
            }

            Console.WriteLine("press any key to continue!");
            Console.ReadKey();
        }

        public void choice2()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("you chose to see if a number is prime \n");

            Console.WriteLine("Please give the number you wish to see is prime or not");
            int numPrime = Convert.ToInt32(Console.ReadLine());
            int counterDivis = 0;
            for (int i = 1; i <= numPrime; i++)
            {
                if (numPrime % i == 0)
                {
                    counterDivis++;
                }
            }
            if (counterDivis == 2)
            {
                Console.WriteLine("{0} is a Prime Number \n", numPrime);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number \n", numPrime);
            }

            Console.WriteLine("press any key to continue!");
            Console.ReadKey();
                       
        }

    }
}
