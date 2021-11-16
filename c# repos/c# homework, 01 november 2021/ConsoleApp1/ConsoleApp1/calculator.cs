using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct calculator
    {
        public void salary() { 
            Console.BackgroundColor = ConsoleColor.Cyan; //sets the background color of the console
            Console.Clear(); //used to color the whole console instead of the background of the text
            Console.ForegroundColor = ConsoleColor.DarkRed; //used to recolor the text
            bool flag2 = false; //flag used to make sure the user does not chose an invalid option (used in the do-while loop)
            do
            {
                Console.WriteLine("Please select option 1 if the employee is salaried and option 2 if employee is hourly");
                int option1 = Convert.ToInt32(Console.ReadLine()); //pulls the choice of the user for use in the if-elseif-else 
                        
                        
                if (option1 == 1)
                {
                    Console.WriteLine("What is the yearly salary for the employee?");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());
                    salary = salary / 12;
                    Console.WriteLine("the monthly salary is " + salary);
                    flag2 = false;
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                }

                else if (option1 == 2)
                {

                    Console.WriteLine("How many hours did the employee work?");
                    decimal hours = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("How much does this employee make per hour?");
                    decimal Wage = Convert.ToDecimal(Console.ReadLine());
                    decimal monthlySalary = Wage * hours;
                    Console.WriteLine("This employee make {0} per month", monthlySalary);
                    flag2 = false;
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("please enter a valid option");
                    flag2 = true;
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();

                }
            }
            while (flag2) ;

        }

        public void passingGrade()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("what is your grade?");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the minimum needed to pass?");
            int minimum = Convert.ToInt32(Console.ReadLine());

            if (grade >= minimum)
            {
                Console.WriteLine("Congratulations you passed!");
            }
            else
            {
                Console.WriteLine("Im sorry you failed");
            }
        }

       



    }
}
