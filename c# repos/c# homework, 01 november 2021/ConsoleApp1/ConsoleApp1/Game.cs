using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Game
    {
        public void factorial()
        {
            int numberInt =1 , factor = 1;
            bool dumbFlag = false;
            do
            {
                Console.WriteLine("Please give me a number to factorialize");
                try
                {
                    numberInt = Convert.ToInt32(Console.ReadLine());
                    dumbFlag = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("choose a valid option next time yeag?\nerror code ardvark.");
                    dumbFlag = true;
                }
            }
            while (dumbFlag);

            for (int i = 1; i <= numberInt; i++) { factor = factor * i; }
            Console.WriteLine("{0} is the number factorilized", factor);
            Console.ReadKey();

        }

        public void rockPaper()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            string computerPick;
            string userPick;

            if(randomNumber == 1){
                computerPick = "rock";
            }
            else if(randomNumber == 2)
            {
                computerPick = "paper";
            }
            else
            {
                computerPick = "scissors";
            }

            Console.WriteLine("Do you chose rock, paper, or scissors!");
            //Console.WriteLine(computerPick);
            userPick = Console.ReadLine().ToLower();
            Console.WriteLine(userPick);
            

            if(userPick[0] == 'r' && computerPick == "scissors")
            {
                Console.WriteLine("You win!! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else if(userPick[0] == 'p' && computerPick == "rock")
            {
                Console.WriteLine("You win!! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else if (userPick[0] == 's' && computerPick == "paper")
            {
                Console.WriteLine("You win!! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else if (userPick[0] == computerPick[0])
            {
                Console.WriteLine("You tied, but i mean if you aint first your last. \nThe computer chose {0} and you chose {1}", computerPick, userPick);
            }
            else
            {
                Console.WriteLine("you suck, and by that i mean you lost! \n The computer chose {0} and you chose {1}", computerPick, userPick);
            }

            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }


        
        public void findSeason()
        {
            Console.WriteLine("Please enter the date you'd like to search (format: MM/DD/YYYY)");
            string inputDate = Console.ReadLine();
            DateTime date = Convert.ToDateTime(inputDate);
            int currentDate = date.DayOfYear;
            if (currentDate >= 79 && currentDate < 171)
            {
                Console.WriteLine("It's spring!");
            }
            else if (currentDate >= 171 && currentDate < 265)
            {
                Console.WriteLine("It's summer!");
            }
            else if (currentDate >= 265 && currentDate < 355)
            {
                Console.WriteLine("It's fall!");
            }
            else
            {
                Console.WriteLine("It's Winter!");
            }
            Console.WriteLine("Please press any key to continue");
            Console.ReadKey();
        }

        public (int, int) SwapNumbers(int a = 5, int b = 10)
        {
            int c = a;
            a = b;
            b = c;
            return (a, b);
        }
    }
            
        }
    

