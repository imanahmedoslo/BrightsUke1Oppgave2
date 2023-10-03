using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        public static int i = 0;
        public static double convertRate = 2.54;
        public static double numberInput = 0;
        public static double convertedResult = 0;
        static void Main(string[] args)
        {
            convertNumbers();
        }
        public static void convertNumbers()
        {
            while (i == 0)
            {
                Console.WriteLine("Hello, tell me want you want to convert! type 1 to convert from CM to inches, " +
                    "and 2 to convert from inches to CM. type any other number to stop");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("Great! tell me the amount you want me to convert");
                    numberInput = double.Parse(Console.ReadLine());
                    Console.WriteLine(numberInput + " CM is the equivalent of " + (numberInput / convertRate) + " in inches.");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Great! tell me the amount you want me to convert");
                    numberInput = double.Parse(Console.ReadLine());
                    Console.WriteLine(numberInput + " inches is the equivalent of " + (numberInput * convertRate) + " in CM.");

                }
                else
                {
                    Console.WriteLine("program will now shut down.");
                    i = 1;
                }

            }

            i = 0;
        }
    }
}
