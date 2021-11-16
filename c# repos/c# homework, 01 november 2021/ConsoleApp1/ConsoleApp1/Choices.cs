using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Choices
    {

        public int choice1()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please choose an option");
            Console.WriteLine("#1 Calculate monthly salary");
            Console.WriteLine("#2 Compare your grade to minimum passing grade");
            Console.WriteLine("#3 Multiply two numbers");
            Console.WriteLine("#4 Divide two numbers");
            Console.WriteLine("#5 Calculate wich of two numbers is bigger");
            Console.WriteLine("#6 Calculate if a number is even or odd");
            Console.WriteLine("#7 Extra Functionalities");
            Console.WriteLine("#8 swap numbers");
            Console.WriteLine("#9 exit the program");
            return Convert.ToInt32(Console.ReadLine());
        }

        public int choice2()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Extra functionalities are as follows: \n");
            Console.WriteLine("1) guess a number between 1 and 10");
            Console.WriteLine("2) determine if a number is prime");
            Console.WriteLine("3) Factorilize a number");
            Console.WriteLine("4) rock papa scissors");
            Console.WriteLine("5) Determine the season");
            Console.WriteLine("6) find the cube of a number");
            Console.WriteLine("7) find the averages of given numbers");
            Console.WriteLine("8) Show multiplication tables");
            Console.WriteLine("9) See if a given string is in alphabetical oprder");

            return Convert.ToInt32(Console.ReadLine());
        }

        public void choicesDefault()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Choose a valid option next time num nuts \nif you want to raise a complaint give them error code beaver\n");
            Console.WriteLine("Press any key to continue...can you handle that?");
            Console.ReadKey();
        }

    }
}
