
using System;
using System.Linq;
using System.Collections.Generic;

namespace CollectionEvent
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Lists
            int guestsNum;
            List<string> guests = new List<string>();
            Console.WriteLine("How many guests are you inviting?");
            guestsNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < guestsNum; i++)
            {
                Console.WriteLine($"Please input guest numer {i + 1}");
                guests.Add(Console.ReadLine());
            }

            Console.WriteLine($"{string.Join(", ", guests)}\n\n");

            string[] sGuests = new string[3];
            sGuests[0] = "Jessica";
            sGuests[1] = "Matt";
            sGuests[2] = "Jon";
            Console.WriteLine($"{string.Join(", ", sGuests)}\n\n");
            #endregion

            #region Dictionaries
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("hello", "Hola!"); //adds a new string "Hola!" at index "hello!
            dictionary.Add("goodbye", "Adios!");
            dictionary.Add("slowly", "Despacito");
            dictionary.Add("tequila", "tequila");


            Console.WriteLine($"Please choose a word you would like to see in spanish {string.Join(", ", dictionary.Keys)}\n\n"); //write all the keys from the dictionary in console
            Console.WriteLine(dictionary[Console.ReadLine().ToLower()]); //gets user input to retrive the corresponding word in spanish
            #endregion

            #region Queue
            Queue<int> bankQueue = new Queue<int>();
            int bankNum;
            Console.WriteLine("How many guests are arriving?");
            bankNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= bankNum; ++i)
            {
                bankQueue.Enqueue(i);

            }
            bool flag = true;
            do
            {
                Console.WriteLine($"say {"next"} when you want the next customer or anything else to leave the bank");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "next")
                {
                    try
                    {
                        int num = bankQueue.Dequeue();
                        Console.WriteLine($"Now serving customer {num} at window number 1.");

                    }
                    catch (Exception e)
                    {
                        string msg = e.Message;
                        Console.WriteLine("You tried to serve another customer but there are no more!");
                        flag = false;
                    }

                }
                else
                {
                    flag = false;
                }
            }
            while (flag);
            #endregion

            #region Stack

            Stack<int> calculator = new Stack<int>();
            bool flag2 = true;
            Console.WriteLine("How many numbers would you like to use fopr the calculator?");
            int times = int.Parse(Console.ReadLine());

            for (int i = 1; i <= times; ++i)
            {
                Console.WriteLine($"Please choose the number at position {i}");
                calculator.Push(int.Parse(Console.ReadLine()));
            }
            int result = calculator.Pop();
            do
            {
                Console.WriteLine("Please chose an operator to use on the numbers submitted \n (EX. *, /, -, +)");

                string choice = Console.ReadLine();

                switch (choice[0])
                {
                    case '*':
                        for (int i = 1; i < times; ++i)
                        {
                            result *= calculator.Pop();
                        }
                        Console.WriteLine($"The result of this operation is {result}");
                        flag2 = false;
                        break;
                    case '/':
                        for (int i = 1; i < times; ++i)
                        {
                            result /= calculator.Pop();
                        }
                        Console.WriteLine($"The result of this operation is {result}");
                        flag2 = false;
                        break;
                    case '-':
                        for (int i = 1; i < times; ++i)
                        {
                            result -= calculator.Pop();
                        }
                        Console.WriteLine($"The result of this operation is {result}");
                        flag2 = false;
                        break;
                    case '+':
                        for (int i = 1; i < times; ++i)
                        {
                            result += calculator.Pop();

                        }
                        Console.WriteLine($"The result of this operation is {result}");
                        flag2 = false;
                        break;
                    default:
                        Console.WriteLine("That was an invalid option, why not try that again chief");
                        break;
                }

            } while (flag2);

            #endregion



            Console.ReadKey();
            Console.Clear();

        }
        


    }

    
}