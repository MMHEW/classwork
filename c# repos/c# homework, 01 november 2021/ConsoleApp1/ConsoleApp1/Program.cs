using System;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            FirstSwitch start = new FirstSwitch();
            do
            {
                
                    start.mainStates();
                
                
                    Console.Clear();
                    Console.WriteLine("Later loser.");
                    Thread.Sleep(1000);

                
            }
            while (flag);

        }
    }
}
