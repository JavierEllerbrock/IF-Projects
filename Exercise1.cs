using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//* In the following exercise it will be determined if a number is multiple of 3, 5, 7 or neither 
namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write(" Please insert a number: ");
            num = int.Parse(Console.ReadLine());

            int num3 = num / 3;
            int num3Rem = num % 3;

            int num5 = num / 5;
            int num5Rem = num % 5;

            int num7 = num / 7;
            int num7Rem = num % 7;


            if (num3Rem == 0)
            {
                Console.WriteLine(" The number is a multiple of 3 ");
            }

            else if (num5Rem == 0)
            {
                Console.WriteLine(" The number is a multiple of 5 ");
            }

            else if (num7Rem == 0)
            {
                Console.WriteLine("The number is a multiple of 7");
            }

            else
            {
                Console.WriteLine(" The number you entered is neither multiple of 3, 5 or 7");

            }

            Console.ReadKey();
        }
    }
}
