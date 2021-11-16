using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExtraSwitch
    {
        public void case7()
        {
            MoreNumbers more = new MoreNumbers();
            Game games = new Game();
            Choices options = new Choices();
            extraFunction functions = new extraFunction(); //instantiates the extraFunction class under the name "functions"
            bool extraFlag = true; //flag for second do-while loop for the second menu
            int extraChoice = 0; //for use in the switch to see what program you go into
            
            do
            {
                
                    extraChoice = options.choice2(); //calls the second options menu from the Choices class
                
                switch (extraChoice)
                {

                    case 1:
                        functions.choice1(); // calls the choice1 method from the extraFunctions class
                        extraFlag = false; //terminated the extra functionalities menu
                        break;

                    case 2:
                        functions.choice2(); // calls the choice2 method from the extraFunctions class
                        extraFlag = false; //terminated the extra functionalities menu
                        break;

                    case 3:
                        games.factorial();
                        extraFlag = false; //terminated the extra functionalities menu
                        break;
                    case 4:
                        games.rockPaper();
                        extraFlag = false; //terminated the extra functionalities menu
                        break;

                    case 5:
                        games.findSeason();
                        extraFlag = false; //terminated the extra functionalities menu
                        break;
                    case 6:
                        more.Cubed();
                        break;
                    case 7:
                        more.Averages();
                        break;
                    case 8:
                        more.MultTables();
                        break;
                    case 9:
                        more.IsAlph();
                        break;

                    default:
                        options.choicesDefault(); //calls the default text from the Choices class 
                        extraFlag = true;
                        break;
                }
               
            }
            while (extraFlag); //keeps extra functionalities menu up if the user make a choice that is not an option
        }
    }
}
