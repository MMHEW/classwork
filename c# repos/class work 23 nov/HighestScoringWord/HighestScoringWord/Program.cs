using System;

namespace HighestScoringWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(High("aa b"));
            Console.WriteLine(High("man i need a taxi up to ubud"));
        }

        public static string High(string s)
        {
            string[] words = s.Split(' ');

            int[] values = new int[words.Length];

            for (int i = 0; i < words.Length; ++i)
            {

                for (int j = 0; j < words[i].Length; ++j)
                {

                    if (j == 0) values[i] = words[i][j];
                    else  values[i] += words[i][j];

                }

            }

            int returnValue = 0;
            for (int i = 0; i < values.Length - 1; ++i)
            {
                if (values[i] > values[i + 1]) returnValue = i;
                else returnValue = (i + 1);

            }

            return words[returnValue];
        }
    }
}
