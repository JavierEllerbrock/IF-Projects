using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num;

            Console.Write("Please insert a number: ");
            num = decimal.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("The number is negative ");
            }

            else if (num > 0)
            {
                Console.WriteLine("The number is positive");
            }

            else
            {
                Console.WriteLine("The number is zero");
            }

            Console.ReadKey();
        }
    }
}
