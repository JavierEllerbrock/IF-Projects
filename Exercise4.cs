using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double score;

            Console.Write("Please insert the final score: ");
            score = double.Parse(Console.ReadLine());

            if (score >= 90 && score <= 100)
            {
                Console.WriteLine("The grade is A");
            }

            else if (score < 90 && score >= 80)
            {
                Console.WriteLine("The grade is B");
            }

            else if (score < 80 && score >= 70)
            {
                Console.WriteLine("The grade is C");
            }

            else if (score < 70 && score >= 60)
            {
                Console.WriteLine("The grade is D");
            }

            else if (score < 60 && score >= 0)
            {
                Console.WriteLine("The grade is F (looser)");
            }
            else
            {
                Console.WriteLine("Please insert a number from 0 to 100");
            }

            Console.ReadKey();

        }
    }
}
