using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPACTIVITY34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a positive integer: ");
            if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            while (number >= 10)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                    number = sum;
                }

                Console.WriteLine("Single-digit result: " + number);
            }
        }
    }
}
