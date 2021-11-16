using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Human
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public int favorite_number { get; set; }

        protected bool open_love_letter = true;

        //private string favoriteFood;

        public Human(string first_name = "John", string last_name = "Doe", int age = 18, int favorite_number = 7)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.favorite_number = favorite_number;
        }
        // Create a method to return the human's favorite number
        public int getFavoriteNumber()
        {
            return this.favorite_number;
        }

        // Create a favoriteFood method to select that the favorite food is pizza.
        //public void setfavoriteFood(string food)
        //{
        //    this.favoriteFood = food;
        //}

        public string getfavoriteFood()
        {
            return "pizza";
        }

        // Create a openLoveLetter method that will only receive read only variables. Human won't be able to open letter.
        public bool openLoveLetter(bool open)
        {
            if (!open)
            {
                Console.WriteLine("sorry human you cannot set it to false");
                return this.open_love_letter;
            }
            else
            {
                Console.WriteLine("true is the only answer");
                return this.open_love_letter;
            }
        }

    }
}
