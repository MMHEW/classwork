using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FirstSwitch
    {
        public void mainStates()
        {
            Choices options = new Choices(); //instantiates the Choices  class under the name "options"
            calculator calc = new calculator(); //instantiates the calculator class under the name "calc"
            teacher teach = new teacher(); //instantiates the teacher class under the name "teach"
            funMath math = new funMath(); //instantiates the funMath class under the name "math"
            Game game = new Game();
            ExtraSwitch seventh = new ExtraSwitch();
            bool flag = true;
            do
            {
                int option = options.choice1(); //retrives the option from the choice1 method in the Choices class for use in the switch statement

                switch (option)
                {

                    case 1:
                        calc.salary(); //calls the salary method from the calculator class 
                        break;

                    case 2:
                        calc.passingGrade(); //calls the passingGrade method from the calculator class
                        break;

                    case 3:
                        teach.multiply(); //calls the multiply method from the teacher class
                        break;

                    case 4:
                        teach.divide(); //calls the division method from the teacher class
                        break;

                    case 5:
                        math.bigNum(); //calls the bigNum method from the funMath class
                        break;

                    case 6:
                        math.evenOdd(); //calls the evenOdd method from the funMath class
                        break;

                    case 7:
                        seventh.case7();
                        break;
                    case 8:
                        Console.WriteLine("Please provide two numbers to swap");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        (a, b) = game.SwapNumbers(a, b);
                        Console.WriteLine($"The first number is not {a} and the second is now {b}");
                        Console.ReadKey();
                        break;
                        
                    case 9:
                        flag = false; //sets the flag to false to allow program to terminate
                        break;

                    default:
                        options.choicesDefault(); //calls the default text from the Choices class 
                        break;

                }
            }

            while (flag); //keeps the first option menu coming up after any option except for 8 is called
        }
    }
}
