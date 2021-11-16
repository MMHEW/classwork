using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MoreNumbers
    {
        #region ClassWork08Nov
        public void Cubed()
        {
            Console.WriteLine("Please give me a number to square");
            int cube = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number squared is {(cube * cube * cube)}");
            Console.ReadKey();
        }
        public void Averages()
        {
            Console.WriteLine("How many numbers are in your average?");
            int result = 0;
            int amount = int.Parse(Console.ReadLine());
            int[] numbers = new int[amount];
            for (int i = 0; i < amount; ++i)
            {
                Console.WriteLine($"Please give me number {i + 1}");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i<amount; ++i)
            {
                result += numbers[i];
            }
            Console.WriteLine($"The numbers averaged it {(result/amount)}");
            Console.ReadKey();
        }
        
        public void MultTables()
        {
            Console.WriteLine("How many numbers do you want to see multiplication tables for?");
            int times = int.Parse(Console.ReadLine());

            for(int i = 1; i<=10; ++i)
            {
                for (int l = 1; l <= times; ++l)
                {
                    Console.Write("" + (l * i) + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        public void IsAlph()
        {
            Console.WriteLine("Please give me letters to see if they are alphabetical");
            string input = Console.ReadLine();
            input = input.ToLower(); // keeps it lowercase incase there is an issue
            char[] arr = (input).ToCharArray(); //converts input into a character array for more functionality

            int[] number = new int[arr.Length]; // holds the letters as numbers
            bool flagAlph = true; //flag used to see if it is in alphabetical order
            //Console.WriteLine("The char values are");
            for (int i = 0; i < arr.Length; ++i) {
                number[i] = (int)arr[i] % 32; //goes through string and converts it to a number correcponding to its place in the alphabet
                //Console.Write(number[i]);
            }
            //Console.WriteLine("\n");
            for(int i = 0; i < (number.Length - 1) ; ++i)
            {
                
                if (number[i] != (number[i+1] - 1)) //tests the numbers against eachother to make sure it is in alphabetical order
                {
                    flagAlph = false;
                }
            }

            //gives the results from above
            if (!flagAlph)
            {
                Console.WriteLine("your input was not in alphabetical order.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("your input was in alphabetical order.");
            Console.ReadKey();


        }

        #endregion
    }

}
 