
namespace Classwork15Nov
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please give the first number");

            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Please give the second number");

            double second = double.Parse(Console.ReadLine());

            CalculatorG<double,double>  calc = new CalculatorG<double, double>(first, second);

            double result = calc.Add();

            Console.WriteLine(result);

        }
    }

}

