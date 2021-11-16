using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite number peasant");
            Human h_mx_l = new Human("Leon", "Maldonado", 25,Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"New human's name: {h_mx_l.first_name}");

            // Get human's favorite number in 2 lines of code
            //int fav = h_mx_l.getFavoriteNumber();
            int fav = h_mx_l.favorite_number;

            // Create a food variable with any value and send it to a favoriteFood method and then print the human's favorite food
           // string food = "Lasagna";
           // h_mx_l.setfavoriteFood(food);
            Console.WriteLine("my fovorite foor is: {0} \nand my favorite number it: {1}", h_mx_l.getfavoriteFood(), fav);


            // Create a boolean variable named closed_love_letter and send it to a openLoveLetter method, but don't allow the human to change the boolean value to false (to open the letter)
            bool closed_love_letter = false;
            closed_love_letter = h_mx_l.openLoveLetter(closed_love_letter);
            
            if (!closed_love_letter)
            {
                closed_love_letter = h_mx_l.openLoveLetter(closed_love_letter);
                Console.WriteLine("the program will not allow you to open the letter by setting 'closed love letter' to false. \nit has reverted the value to {0}", closed_love_letter);
            }
            else{
                closed_love_letter = h_mx_l.openLoveLetter(closed_love_letter);
                Console.WriteLine("The program apprecaited that you didnt try to open the letter \nThe program kept the value {0}", closed_love_letter);

            }
            
            


            Console.ReadKey();
        }
    }
}
