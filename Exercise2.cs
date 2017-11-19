using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Please insert your age: ");
            age = int.Parse(Console.ReadLine());

            if (0 < age && age < 2)
            {
                Console.WriteLine("You are a baby");
            }

            else if (2 <= age && age < 4)
            {
                Console.WriteLine("You are a toddler");
            }

            else if (4 <= age && age < 12)
            {
                Console.WriteLine("You are a child");
            }

            else if (12 <= age && age < 21)
            {
                Console.WriteLine("You are a teenager (acording to U.S law)");
            }

            else if (21 <= age && age < 50)
            {
                Console.WriteLine("You are an adult");
            }

            else if (age >= 50)
            {
                Console.WriteLine("You are a senior");
            }

            Console.ReadKey();
        }
    }
}
